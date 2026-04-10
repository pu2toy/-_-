using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Models
{
    public class DataService
    {
        private readonly string clientFile = "crm_data.json";

        public List<ClientModel> LoadClients()
        {
            if (!File.Exists(clientFile))
                return new List<ClientModel>();

            var json = File.ReadAllText(clientFile);
            return JsonConvert.DeserializeObject<List<ClientModel>>(json)
                   ?? new List<ClientModel>();
        }

        public void SaveClients(List<ClientModel> clients)
        {
            var json = JsonConvert.SerializeObject(clients, Formatting.Indented);
            File.WriteAllText(clientFile, json);
        }
    }
}
