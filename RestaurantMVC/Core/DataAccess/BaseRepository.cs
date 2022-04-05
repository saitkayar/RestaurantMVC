using Microsoft.EntityFrameworkCore;
using RestaurantMVC.Core.Model;
using RestaurantMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantMVC.Core.DataAccess
{
    public class BaseRepository<T, TContext> : IBaseRepository<T> where T : class, IModel, new()
    {
        public bool Add(T model)
        {
            using (var context = new RestaurantDbContext())
            {
                var addedModel = context.Entry(model);
                addedModel.State = EntityState.Added;
                context.SaveChanges();
                return true;

            }
        }

        public bool Delete(int id)
        {
            var model = this.GetById(id);
            using (var context = new RestaurantDbContext())
            {
                var deletedModel = context.Entry(model);
                deletedModel.State = EntityState.Deleted;
                context.SaveChanges();
                return true;
            }
        }

        public List<T> Getall()
        {
            using (var context=new RestaurantDbContext())
            {
                return context.Set<T>().ToList();

            }
        }

        public T GetById(int id)
        {
            using (var context = new RestaurantDbContext())
            {
                return context.Set<T>().SingleOrDefault(u => u.Id == id);
            }
        }

        public bool Update(T model)
        {
            using (var context = new RestaurantDbContext())
            {
                var updatedModel = context.Entry(model);
                updatedModel.State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
        }
    }
}