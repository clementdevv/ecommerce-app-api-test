using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app_api.Models
{
    public class Invoice
    {
        public int buyerId { get; set; }
        public int orderId { get; set; }
        public int orderMadeAt { get; set; }
    }
}