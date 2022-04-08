using RestaurantMVC.Core.Model;
using System.Collections.Generic;

namespace RestaurantMVC.Models
{
    public class Table : IModel
    {
        public int Id { get; set; }
        public Section Section { get; set; }
        public bool IsFull { get; set; }
    }
}
