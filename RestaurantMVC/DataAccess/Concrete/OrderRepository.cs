using RestaurantMVC.Core.DataAccess;
using RestaurantMVC.DataAccess.Abstract;
using RestaurantMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMVC.DataAccess.Concrete
{
    public class OrderRepository : BaseRepository<Order, RestaurantDbContext>, IOrderRepository
    {
        public List<OrderDto> GetByProduct()
        {
            using (var context = new RestaurantDbContext())
            {
                var result = from p in context.Products
                             join o in context.Orders on p.Id equals o.ProductId
                             join t in context.Tables on o.TableId equals t.Id
                  
                             select new OrderDto()
                             {
                                 Id = o.Id,
                                 ProductName = p.ProductName,
                                 Quantity = o.Quantity,
                              ProductPrice=p.ProductPrice,
                              TableId=t.Id
                             };
                return result.ToList();


            }
        }

    }

}

