using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app_api.Models
{
    public class OrderItem
    {
        public int orderId { get; set; }
        public int? productId { get; set; }
        //Navigation Property
        public Product? Product {get; set;}
        public float quantity { get; set; }
    }
}