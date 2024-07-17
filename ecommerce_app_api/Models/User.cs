using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app_api.Models
{
    public class User
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string emailAddress { get; set; }
    }
}