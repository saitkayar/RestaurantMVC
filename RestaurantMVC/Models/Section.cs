using RestaurantMVC.Core.Model;

namespace RestaurantMVC.Models
{
    public class Section : IModel
    {
        public int Id { get; set; }
        public string SectionName { get; set; }

    }
}
