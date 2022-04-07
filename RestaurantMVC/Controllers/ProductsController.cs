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
    public class ProductsController : Controller
    {
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        public ProductsController()
        {
            _productRepository = new ProductRepository();

            _categoryRepository = new CategoryRepository();
        }

        public IActionResult Index()
        {
            ViewBag.products = this._productRepository.GetAllWithCategory();
            return View();
        }
        public IActionResult Add()
        {
            ViewBag.categories = this._categoryRepository.Getall();
            return View();
        }
        public IActionResult Update(int id)
        {
            var product = this._categoryRepository.GetById(id);
            if (product == null)
            {
                RedirectToAction("Index");
            }
            ViewBag.product = product;
            return View();

        }
        public IActionResult DeleteById(int id)
        {
            this._productRepository.Delete(id);
            return RedirectToAction("index");
        }
        [HttpPost]
        public IActionResult Save(Product product)
        {
            string route = (product.Id == 0) ? "Add" : "Update";
          
          
            if (product.ProductName == null)
            {
                return RedirectToAction(route ,"Please enter Name");
            }
            if (product.CategoryId == 0)
            {
                return RedirectToAction(route,"Please select CategoryId");
            }
            if (product.ProductPrice == 0)
            {
                return RedirectToAction(route,  "Please enter Price");
            }
           
            if (product.Id == 0)
            {
                this._productRepository.Add(product);
            }
            else
            {
                this._productRepository.Update(product);
            }
            return RedirectToAction("Index");
        }
    }
}
