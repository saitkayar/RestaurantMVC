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
                             join e in context.Employees on o.EmployeeId equals e.Id
                  
                             select new OrderDto()
                             {
                                 Id = o.Id,
                                 ProductName = p.ProductName,
                                 Quantity = o.Quantity,
                              ProductPrice=p.ProductPrice,
                              TableId=t.Id,
                                 Total = (p.ProductPrice * o.Quantity) - o.Discount,
                                 SubTotal = p.ProductPrice * o.Quantity,
                              Discount=o.Discount,
                                 Date = DateTime.Now,
                                 FullName=e.Name+" "+e.SurName

                             };
                return result.ToList();


            }
        }

    }

}

