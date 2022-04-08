using RestaurantMVC.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMVC.Models
{
    public class Bill:IModel
    {
        public int Id { get; set; }
        public decimal SubTotal { get; set; }
        //public decimal Discount { get; set; }
        //public decimal Total { get; set; }
        public  ICollection <Product> Products { get; set; }

   public virtual Order Order { get; set; }
        public DateTime Date { get; set; }


    }
}
