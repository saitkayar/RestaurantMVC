using RestaurantMVC.Core.Model;

namespace RestaurantMVC.Models
{
    public class Category:IModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

    }
}
