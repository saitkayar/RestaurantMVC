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
    public class SectionsController : Controller
    {
        private ISectionRepository _sectionRepository;

        public SectionsController()
        {
            _sectionRepository = new SectionRepository();
        }

        public IActionResult Index()
        {
          ViewBag.sections=_sectionRepository.Getall();
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Save(Section section)
        {
            if (section.Id==0)
            {
                _sectionRepository.Add(section);
            }
           else
            {
                _sectionRepository.Update(section);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var section = _sectionRepository.GetById(id);
            if (section == null)
            {
                return RedirectToAction("Index");

            }
            ViewBag.section = section;
            return View();
        }
        public IActionResult DeleteById(int id)
        {
            this._sectionRepository.Delete(id);
            return RedirectToAction("Index");
            
        }
    }
}
