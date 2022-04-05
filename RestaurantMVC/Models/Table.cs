using RestaurantMVC.Core.Model;

namespace RestaurantMVC.Models
{
    public class Table : IModel
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public bool IsFull { get; set; }
    }
}
