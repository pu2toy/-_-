using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Task01.Windows;

namespace Task01.ViewModels
{
    public class MainWindowVM
    {
        public ObservableCollection<Client> Clients { get; set; } = new ObservableCollection<Client>();

        private Client _selectedClient;
        public Client SelectedClient
        {
            get => _selectedClient;
            set
            {
                _selectedClient = value;
                CommandManager.InvalidateRequerySuggested();
            }
        }

        public ICommand AddClientCommand { get; }
        public ICommand DeleteClientCommand { get; }
        public ICommand EditClientCommand { get; }

        public MainWindowVM()
        {
            AddClientCommand = new RelayCommand(_ => AddClient());
            DeleteClientCommand = new RelayCommand(_ => DelClient(), _ => SelectedClient != null);
            EditClientCommand = new RelayCommand(_ => EditClient(), _ => SelectedClient != null);
        }

        public void AddClient()
        {
            var vm = new ClientDialogViewModel();
            var window = new ClientDialogWindow
            {
                DataContext = vm
            };
            window.ShowDialog();

            if (vm.ClientSaved)
                Clients.Add(vm.Client);
        }

        public void DelClient()
        {
            if (SelectedClient == null) return;

            if (MessageBox.Show($"Удалить клиента {SelectedClient.FullName}?", "Подтверждение",
                MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                Clients.Remove(SelectedClient);
            }
        }

        public void EditClient()
        {
            if (SelectedClient == null) return;

            var vm = new ClientDialogViewModel
            {
                Client = new Client { FullName = SelectedClient.FullName, Contact = SelectedClient.Contact }
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
            }
        }
    }
}
