using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app_api.Models
{
    public class Product
    {
        //use string.Empty to avoid a null reference error
        public int Id { get; set; }
        public string categoryName { get; set; } = string.Empty;             
        public int categoryId { get; set; }
        public string productName { get; set; } = string.Empty;
        public string productDescription { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal markedPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal sellingPrice { get; set; }
        [Column(TypeName = "decimal(2,10)")]
        public float percentageDiscount { get; set; }
        [Column(TypeName = "decimal(18,5)")]
        public float quantity { get; set; }
        //order item would be a fk and product be the pk; one to many relationship
        public List<OrderItem> OrderItems { get; set;} = new List<OrderItem>();

        
        
    }
}