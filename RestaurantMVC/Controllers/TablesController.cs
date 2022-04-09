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
         ViewBag.tables=_tableRepository.GetTableDtos();
            return View();
        }

        public IActionResult Add()
        {
            ViewBag.sections = _sectionRepository.Getall();
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
        public IActionResult Update(int id)
        {
            ViewBag.sections = _sectionRepository.Getall();
            var table = _tableRepository.GetById(id);
            if (table==null)
            {
                RedirectToAction("Index");
            }
            ViewBag.table = table;
            return View();
        }

        public IActionResult DeleteById(int id)
        {
            _tableRepository.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
