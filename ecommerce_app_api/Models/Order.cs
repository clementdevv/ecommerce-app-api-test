using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app_api.Models
{
    public class Order
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string orderMadeAt { get; set; }
        public string orderStatus { get; set; }
    }
}