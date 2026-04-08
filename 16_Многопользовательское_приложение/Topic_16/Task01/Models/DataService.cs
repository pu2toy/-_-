using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Task01.Models
{
    public class DataService
    {
        private string path = "crm_data.json";

        public CrmData Load()
        {
            if (!File.Exists(path))
                return new CrmData { Clients = new List<ClientModel>(), Orders = new List<OrderModel>() };

            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<CrmData>(json);
        }

        public void Save(List<ClientModel> clients, List<OrderModel> orders)
        {
            var data = new CrmData
            {
                Clients = clients,
                Orders = orders
            };

            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }
    }
}
