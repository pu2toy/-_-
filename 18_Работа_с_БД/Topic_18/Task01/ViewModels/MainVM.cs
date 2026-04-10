using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Task01.Models;
using Task01.View;
using Task01.Data;
using System.IO;

namespace Task01.ViewModels
{
    public class MainVM : INotifyPropertyChanged
    {
        private DataService _dataService = new DataService();

        private FileSystemWatcher _watcher;
        public ObservableCollection<ClientModel> Clients { get; set; } = new ObservableCollection<ClientModel>();
        public ObservableCollection<OrderModel> Orders { get; set; } = new ObservableCollection<OrderModel>();

        private ClientRepository _repository = new ClientRepository();

        private ClientModel _selectedClient;
        private bool _isLoading;
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void InitWatcher()
        {
            _watcher = new FileSystemWatcher(".", "crm_data.json");
            _watcher.Changed += (s, e) =>
            {
                Application.Current.Dispatcher.Invoke(async () =>
                {
                    await LoadClientsAsync();
                });
            };
            _watcher.EnableRaisingEvents = true;
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

            var clients = await _repository.GetAllClientsAsync();

            Clients.Clear();
            foreach (var c in clients)
                Clients.Add(c);

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
            InitWatcher();
        }

        public async void AddClient()
        {
            var vm = new ClientDialogVM();
            var window = new ClientDialogWindow
            {
                DataContext = vm
            };
            window.ShowDialog();

            if (vm.ClientSaved)
            {
                await _repository.AddClientAsync(vm.Client);
                Clients.Add(vm.Client);
            }
        }

        public async void DelClient()
        {
            if (SelectedClient == null) return;

            if (MessageBox.Show($"Удалить клиента {SelectedClient.FullName}?",
                "Подтверждение",
                MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                await _repository.DeleteClientAsync(SelectedClient);
                Clients.Remove(SelectedClient);
            }
        }

        public async void EditClient()
        {
            if (SelectedClient == null) return;

            var vm = new ClientDialogVM
            {
                Client = new ClientModel
                {
                    Id = SelectedClient.Id,
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

                await _repository.UpdateClientAsync(SelectedClient);
            }
        }
    }
}
