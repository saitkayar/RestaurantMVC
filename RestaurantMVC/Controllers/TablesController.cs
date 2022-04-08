using Microsoft.AspNetCore.Mvc;
using RestaurantMVC.DataAccess.Abstract;
using RestaurantMVC.DataAccess.Concrete;
using RestaurantMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMVC.Controllers
{
    public class TablesController : Controller
    {
        private ITableRepository _tableRepository;

        public TablesController()
        {
            _tableRepository = new TableRepository();
        }


        public IActionResult Index()
        {

         ViewBag.tables=_tableRepository.Getall();
            return View();
        }
    }
}
