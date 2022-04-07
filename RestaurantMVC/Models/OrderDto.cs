using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMVC.Models
{
    public class OrderDto
    {
        public int Id { get; set; }

        public string ProductName { get; set; }
        //public int TableId { get; set; }
        public int Quantity { get; set; }
        //public int EmployeeId { get; set; }
    }
}
