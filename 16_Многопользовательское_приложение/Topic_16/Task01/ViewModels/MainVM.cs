using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Task01.Models;
using Task01.View;

namespace Task01.ViewModels
{
    public class MainVM : INotifyPropertyChanged
    {
        private DataService _dataService = new DataService();
        public ObservableCollection<ClientModel> Clients { get; set; } = new ObservableCollection<ClientModel>();
        public ObservableCollection<OrderModel> Orders { get; set; } = new ObservableCollection<OrderModel>();

        private ClientService _clientService = new ClientService();

        private ClientModel _selectedClient;
        private bool _isLoading;
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        
        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        public async Task LoadClientsAsync()
        {
            IsLoading = true;

            var data = await Task.Run(() =>
            {
                Thread.Sleep(1000);
                return _dataService.Load();
            });

            Clients.Clear();
            Orders.Clear();

            foreach (var c in data.Clients)
                Clients.Add(c);

            foreach (var o in data.Orders)
                Orders.Add(o);

            IsLoading = false;
        }

        public ClientModel SelectedClient
        {
            get => _selectedClient;
            set
            {
                _selectedClient = value;
                OnPropertyChanged(nameof(SelectedClient));
                CommandManager.InvalidateRequerySuggested();
            }
        }

        public ICommand AddClientCommand { get; }
        public ICommand DeleteClientCommand { get; }
        public ICommand EditClientCommand { get; }

        public MainVM()
        {
            AddClientCommand = new RelayCommand(_ => AddClient());
            DeleteClientCommand = new RelayCommand(_ => DelClient(), _ => SelectedClient != null);
            EditClientCommand = new RelayCommand(_ => EditClient(), _ => SelectedClient != null);

            _ = LoadClientsAsync();
            StartPipeServer();
            StartFileWatcher();
        }

        private void StartPipeServer()
        {
            Task.Run(async () =>
            {
                var server = new NamedPipeServerStream(
                    "crm_pipe",
                    PipeDirection.In,
                    1, 
                    PipeTransmissionMode.Message,
                    PipeOptions.Asynchronous);

                while (true)
                {
                    await server.WaitForConnectionAsync();

                    try
                    {
                        using (var reader = new StreamReader(server))
                        {
                            string message = await reader.ReadLineAsync();

                            Application.Current.Dispatcher.Invoke(() =>
                            {
                                Orders.Add(new OrderModel
                                {
                                    Title = message,
                                    Price = 0
                                });
                            });
                        }
                    }
                    catch { }

                    server.Disconnect();
                }
            });
        }

        private void StartFileWatcher()
        {
            var watcher = new FileSystemWatcher
            {
                Path = Directory.GetCurrentDirectory(),
                Filter = "crm_data.json"
            };

            watcher.Changed += (s, e) =>
            {
                Application.Current.Dispatcher.Invoke(async () =>
                {
                    await LoadClientsAsync();
                });
            };

            watcher.EnableRaisingEvents = true;
        }

        public void AddClient()
        {
            var vm = new ClientDialogVM();
            var window = new ClientDialogWindow
            {
                DataContext = vm
            };
            window.ShowDialog();

            if (vm.ClientSaved)
            {
                _clientService.AddClient(vm.Client);
                Clients.Add(vm.Client);
            }

            _dataService.Save(Clients.ToList(), Orders.ToList());
        }

        public void DelClient()
        {
            if (SelectedClient == null) return;

            if (MessageBox.Show($"Удалить клиента {SelectedClient.FullName}?", "Подтверждение",
                MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                _clientService.DeleteClient(SelectedClient);
                Clients.Remove(SelectedClient);
            }

            _dataService.Save(Clients.ToList(), Orders.ToList());
        }

        public void EditClient()
        {
            if (SelectedClient == null) return;
            var vm = new ClientDialogVM
            {
                Client = new ClientModel
                {
                    FullName = SelectedClient.FullName,
                    Contact = SelectedClient.Contact,
                    ClientType = SelectedClient.ClientType
                }
            };

            var window = new ClientDialogWindow
            {
                DataContext = vm
            };

            window.ShowDialog();

            if (vm.ClientSaved)
            {
                SelectedClient.FullName = vm.Client.FullName;
                SelectedClient.Contact = vm.Client.Contact;
                SelectedClient.ClientType = vm.Client.ClientType;

                foreach (var order in Orders.Where(o => o.client == SelectedClient))
                {
                    order.client.FullName = SelectedClient.FullName;
                }

                _dataService.Save(Clients.ToList(), Orders.ToList());
            }
        }
    }
}
