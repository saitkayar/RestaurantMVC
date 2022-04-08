using RestaurantMVC.Core.DataAccess;
using RestaurantMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMVC.DataAccess.Abstract
{
   public interface IOrderRepository:IBaseRepository<Order>
    {
        //public List<OrderDto> GetByProduct();
    }
}
