using RestaurantMVC.Core.Model;

namespace RestaurantMVC.Models
{
    public class Order : IModel
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public int ProductId { get; set; }
        public int TableId { get; set; }
        public int Quantity { get; set; }
        public int EmployeeId { get; set; }

    }
}
