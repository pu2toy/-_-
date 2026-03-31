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
using System.Windows.Shapes;

namespace Task01
{
    /// <summary>
    /// Логика взаимодействия для AddClientWindow.xaml
    /// </summary>
    public partial class AddClientWindow : Window
    {
        public AddClientWindow()
        {
            InitializeComponent();
        }

        public Client NewClient { get; set; }
        
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            NewClient = new Client
            {
                FullName = NameBox.Text,
                Contact = ContactBox.Text,
                History = HistoryBox.Text
            };

            DialogResult = true;
        }
    }
}
