using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Models
{
    public class CrmData
    {
        public List<ClientModel> Clients { get; set; }
        public List<OrderModel> Orders { get; set; }
    }
}
