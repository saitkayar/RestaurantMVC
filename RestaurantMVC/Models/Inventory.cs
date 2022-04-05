using RestaurantMVC.Core.Model;

namespace RestaurantMVC.Models
{
    public class Inventory : IModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

    }
}
