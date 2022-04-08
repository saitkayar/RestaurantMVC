using RestaurantMVC.Core.DataAccess;
using RestaurantMVC.DataAccess.Abstract;
using RestaurantMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMVC.DataAccess.Concrete
{
    public class TableRepository:BaseRepository<Table,RestaurantDbContext>, ITableRepository
    {
    }
}
