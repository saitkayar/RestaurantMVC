using RestaurantMVC.Core.DataAccess;
using RestaurantMVC.DataAccess.Abstract;
using RestaurantMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMVC.DataAccess.Concrete
{
    public class TableRepository : BaseRepository<Table, RestaurantDbContext>, ITableRepository
    {
        public List<TableDto> GetTableDtos()
        {
            using (var context=new RestaurantDbContext())
            {
                var result = from s in context.Sections
                             join t in context.Tables on s.Id equals t.SectionId
                             select new TableDto()
                             {
                                 TableId = t.Id,
                                 SectionName = s.SectionName
                             };
                return result.ToList();

            }     
        }
    }
}
