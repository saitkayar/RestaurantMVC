using RestaurantMVC.Core.Model;

namespace RestaurantMVC.Models
{
    public class Product : IModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }

    }
}
