using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task01
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            AddClientWindow window = new AddClientWindow();

            if (window.ShowDialog() == true)
            {
                var vm = (MainViewModel)DataContext;
                vm.Clients.Add(window.NewClient);
            }
        }

        private void EditClient_Click(object sender, RoutedEventArgs e)
        {
            if (ClientList.SelectedItem is Client selected)
            {
                AddClientWindow window = new AddClientWindow();

                window.NameBox.Text = selected.FullName;
                window.ContactBox.Text = selected.Contact;
                window.HistoryBox.Text = selected.History;

                if (window.ShowDialog() == true)
                {
                    selected.FullName = window.NewClient.FullName;
                    selected.Contact = window.NewClient.Contact;
                    selected.History = window.NewClient.History;

                    ClientList.Items.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Выберите клиента");
            }
        }

        private void DeleteClient_Click(object sender, RoutedEventArgs e)
        {
            var vm = (MainViewModel)DataContext;

            if (ClientList.SelectedItem is Client selected)
            {
                vm.Clients.Remove(selected);
            }
            else
            {
                MessageBox.Show("Выберите клиента");
            }
        }
    }
}
