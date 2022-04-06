using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMVC.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string CategoryName{ get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
