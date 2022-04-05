using RestaurantMVC.Core.Model;

namespace RestaurantMVC.Models
{
    public class Employee : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

    }
}
