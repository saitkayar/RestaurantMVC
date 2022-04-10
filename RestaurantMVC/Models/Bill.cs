using RestaurantMVC.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMVC.Models
{
    public class Bill:IModel
    {
        public int Id { get; set; }
    
      
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public DateTime Date { get; set; }


    }
}
