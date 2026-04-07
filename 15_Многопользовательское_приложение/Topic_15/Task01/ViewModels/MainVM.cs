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

namespace Task01.ViewModels
{
    public class MainVM : INotifyPropertyChanged
    {
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

            var clients = await Task.Run(() =>
            {
                Thread.Sleep(2000);
                return _clientService.GetClients();
            });

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
        }

        public void EditClient()
        {
            if (SelectedClient == null) return;

            var vm = new ClientDialogVM
            {
                Client = new ClientModel { FullName = SelectedClient.FullName, Contact = SelectedClient.Contact }
            };

            var window = new ClientDialogWindow
            {
                DataContext = vm
            };

            window.ShowDialog();

            if (vm.ClientSaved)
            {
                _clientService.UpdateClient(SelectedClient, vm.Client);
            }
        }
    }
}
