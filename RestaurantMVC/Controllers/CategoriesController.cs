﻿using Microsoft.AspNetCore.Mvc;
using RestaurantMVC.DataAccess.Abstract;
using RestaurantMVC.DataAccess.Concrete;
using RestaurantMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMVC.Controllers
{
    public class CategoriesController : Controller
    {
        private ICategoryRepository _categoryRepository;

        public CategoriesController()
        {
            _categoryRepository = new CategoryRepository();
        }

        public IActionResult Index()
        {
            ViewBag.categories = _categoryRepository.Getall();
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Update(int id)
        {
            var category = _categoryRepository.GetById(id);
            if (category==null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.category = category;
            return View();
           
        }

        public IActionResult Save(Category category)
        {
          string route=  (category.Id == 0) ? "Add" : "Update";
            if (category.CategoryName == null)
            {
                return BadRequest( "Please enter Name");
            }
            if (category.Id == 0)
            {
                this._categoryRepository.Add(category);
            }
            else
            {
                this._categoryRepository.Update(category);
            }
            return Ok(category);
        }

        public IActionResult DeleteById(int id)
        {
            _categoryRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
