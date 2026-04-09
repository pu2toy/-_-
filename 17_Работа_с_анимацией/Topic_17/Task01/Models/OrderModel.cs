using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Models
{
    public class OrderModel
    {
        public string Title { get; set; }
        public decimal Price { get; set; }  
        public ClientModel client { get; set; }
    }
}
