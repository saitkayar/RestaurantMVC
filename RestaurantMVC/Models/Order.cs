using RestaurantMVC.Core.Model;
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
        public int TableId { get; set; }
        public int Quantity { get; set; }
        //public virtual Employee Employee { get; set; }

    }
}
