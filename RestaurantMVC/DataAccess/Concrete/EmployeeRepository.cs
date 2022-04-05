using RestaurantMVC.Core.DataAccess;
using RestaurantMVC.DataAccess.Abstract;
using RestaurantMVC.Models;

namespace RestaurantMVC.DataAccess.Concrete
{
    public class EmployeeRepository : BaseRepository<Employee, RestaurantDbContext>, IEmployeeRepository
    {
    }
}
