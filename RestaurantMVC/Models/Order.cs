using RestaurantMVC.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantMVC.Models
{
    public class Order : IModel
    {
     
        public int Id { get; set; }

        //public ICollection<Product> Products { get; set; }
        public int ProductId { get; set; }

        public int EmployeeId { get; set; }
        public int Quantity { get; set; }
        public int TableId { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }

       
        public DateTime Date { get; set; }

    }
}
