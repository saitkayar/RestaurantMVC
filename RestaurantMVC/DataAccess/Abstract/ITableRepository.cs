using RestaurantMVC.Core.DataAccess;
using RestaurantMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMVC.DataAccess.Abstract
{
   public interface ITableRepository:IBaseRepository<Table>
    {

        public List<TableDto> GetTableDtos();

    }
}
