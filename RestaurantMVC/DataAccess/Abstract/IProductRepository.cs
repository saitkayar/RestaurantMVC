using RestaurantMVC.Core.DataAccess;
using RestaurantMVC.Models;
using System.Collections.Generic;

namespace RestaurantMVC.DataAccess.Abstract
{
  public  interface IProductRepository : IBaseRepository<Product>
    {
        ////{
        public List<ProductDto> GetAllWithCategory();
        ////    public List<Product> GetAllByCategoryId(int categoryId);
        //}

    }
}
