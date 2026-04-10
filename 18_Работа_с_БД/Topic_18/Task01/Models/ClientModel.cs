using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Models
{
    public class ClientModel : INotifyPropertyChanged
    {
        public int Id { get; set; }
        private string _fullName;
        private string _contact;
        private string _clientType;

        public string FullName
        {
            get => _fullName;
            set
            {
                if (_fullName != value)
                {
                    _fullName = value;
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }

        public string Contact
        {
            get => _contact;
            set
            {
                if (_contact != value)
                {
                    _contact = value;
                    OnPropertyChanged(nameof(Contact));
                }
            }
        }

        public string ClientType
        {
            get => _clientType;
            set
            {
                if (_clientType != value)
                {
                    _clientType = value;
                    OnPropertyChanged(nameof(ClientType));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
