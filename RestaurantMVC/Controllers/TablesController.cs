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
        private ISectionRepository _sectionRepository;

        public TablesController()
        {
            _tableRepository = new TableRepository();
            _sectionRepository = new SectionRepository();
        }


        public IActionResult Index()
        {
         var values=_tableRepository.Getall();
            return View(values);
        }

        public IActionResult Add()
        {
            //ViewBag.sections = _sectionRepository.Getall();
            return View();
        }
        public IActionResult Save(Table table)
        {
            if (table.Id==0)
            {
                _tableRepository.Add(table);
            }
            else
            {
                _tableRepository.Update(table);
            }
            return RedirectToAction("Index");
        }

    }
}
