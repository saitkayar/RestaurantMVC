using RestaurantMVC.Core.Model;

namespace RestaurantMVC.Models
{
    public class Product : IModel
    {
        public int Id { get; set; }
        public virtual Category Category { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }


    }
}
