using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.Models;
using System.Windows;
using System.Windows.Input;

namespace Task01.ViewModels
{
    public class ClientDialogVM
    {
        public List<string> ClientTypes { get; } = new List<string>
            {
                "Обычный",
                "VIP"
            };
        public ClientModel Client { get; set; } = new ClientModel();
        public bool ClientSaved { get; private set; } = false;

        public ICommand SaveCommand { get; }
        public ICommand CancelCommand { get; }

        public ClientDialogVM()
        {
            SaveCommand = new RelayCommand(_ => Save());
            CancelCommand = new RelayCommand(_ => Cancel());
        }

        private void Save()
        {
            if (string.IsNullOrWhiteSpace(Client.FullName))
            {
                MessageBox.Show("Введите имя клиента");
                return;
            }
            ClientSaved = true;
            CloseWindow();
        }

        private void Cancel()
        {
            ClientSaved = false; CloseWindow();
        }

        private void CloseWindow()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.DataContext == this)
                {
                    window.Close();
                    break;
                }
            }
        }
    }
}
