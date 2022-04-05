using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMVC.Core.DataAccess
{
    public  interface IBaseRepository<T>
    {
        List<T> Getall();
        T GetById(int id);
        bool Add(T model);
        bool Delete(int id);
        bool Update(T model);

    }
}
