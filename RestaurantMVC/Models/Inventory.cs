using RestaurantMVC.Core.Model;
using System.Collections.Generic;

namespace RestaurantMVC.Models
{
    public class Inventory : IModel
    {
        public int Id { get; set; }
        public ICollection<Product> Products { get; set; }
        public int Quantity { get; set; }

    }
}
