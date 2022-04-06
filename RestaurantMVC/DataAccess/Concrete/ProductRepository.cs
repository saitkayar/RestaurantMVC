using RestaurantMVC.Core.DataAccess;
using RestaurantMVC.DataAccess.Abstract;
using RestaurantMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantMVC.DataAccess.Concrete
{
    public class ProductRepository : BaseRepository<Product, RestaurantDbContext>, IProductRepository
    {
        //public List<Product> GetAllByCategoryId(int categoryId)
        //{
        //    using (var context = new RestaurantDbContext())
        //    {
        //        return context.Set<Product>().Where(p => p.CategoryId == categoryId).ToList();

        //    }
        //}

        public List<ProductDto> GetAllWithCategory()
        {
            using (var context = new RestaurantDbContext())
            {
                var result = from p in context.Products
                             join c in context.Categories on p.CategoryId equals c.Id
                             select new ProductDto()
                             {
                                 Id = p.Id,
                                 CategoryName = c.CategoryName,
                                 ProductName = p.ProductName,
                                 ProductPrice=p.ProductPrice
                             };
                return result.ToList();
            }

        }
    }
}
