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
                             join p in context.Products on b.ProductId equals p.Id
                             join o in context.Orders on b.OrderId equals o.Id
                             select new CalculateDto()
                             {
                                 Id = b.Id,
                              
                                 SubTotal = (p.ProductPrice * o.Quantity),
                                 Date = DateTime.Today,
                                 ProductName=p.ProductName,
                                 Quantity=o.Quantity
                                
                                 
                             };
                return result.ToList();

            }
        }
    }
}
