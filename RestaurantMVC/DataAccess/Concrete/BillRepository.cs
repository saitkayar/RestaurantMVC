using RestaurantMVC.Core.DataAccess;
using RestaurantMVC.DataAccess.Abstract;
using RestaurantMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMVC.DataAccess.Concrete
{
    public class BillRepository:BaseRepository<Bill,RestaurantDbContext>,IBillRepository
    {
        public List<CalculateDto> Calculate()
        {
            using (var context=new RestaurantDbContext())
            {
                var result = from b in context.Bills
                             join p in context.Products on b.ProductId  equals p.Id
                             join  o in context.Orders on b.OrderId equals o.Id
                          
                             select new CalculateDto()
                             {
                                 BillId= b.Id,
                             
                                 SubTotal = p.ProductPrice *o.Quantity,
                                 Discount = b.Discount,
                                 Total=(p.ProductPrice * o.Quantity)-b.Discount,
                                 ProductName = p.ProductName,
                                 Quantity=o.Quantity,
                                 ProductPrice=p.ProductPrice,
                                 Date = DateTime.Now,
                                    Table=o.TableId
                                 
                             };
                return result.ToList();

            }
        }
    }
}
