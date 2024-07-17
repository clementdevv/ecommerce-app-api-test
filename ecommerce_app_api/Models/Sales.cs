using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app_api.Models
{
    public class Sales
    {
        public int productSoldId { get; set; }
        public float remainingQuantity { get; set; }
    }
}