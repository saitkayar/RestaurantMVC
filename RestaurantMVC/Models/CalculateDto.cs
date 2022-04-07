using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMVC.Models
{
    public class CalculateDto
    {
        public int Id { get; set; }

        public decimal SubTotal { get; set; }
        //public decimal Discount { get; set; }
        //public decimal Total { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal ProductPrice { get; set; }
        public DateTime Date { get; set; }
    }
}
