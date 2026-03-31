using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Task01
{
    public class MainViewModel
    {
        public ObservableCollection<Client> Clients { get; set; }

        public MainViewModel()
        {
            Clients = new ObservableCollection<Client>();
        }
    }
}
