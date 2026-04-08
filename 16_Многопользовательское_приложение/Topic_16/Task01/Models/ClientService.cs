using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Models
{
    public class ClientService
    {
        private List<ClientModel> _clients = new List<ClientModel>();
        
        public List<ClientModel> GetClients() => _clients;
        public void AddClient(ClientModel client) => _clients.Add(client);
        public void DeleteClient(ClientModel client) => _clients.Remove(client);

        public void UpdateClient(ClientModel oldClient, ClientModel newClient)
        {
            oldClient.FullName = newClient.FullName;
            oldClient.Contact = newClient.Contact;
            oldClient.ClientType = newClient.ClientType;
        }
    }
}
