using Microsoft.AspNetCore.Mvc;
using RestaurantMVC.DataAccess.Abstract;
using RestaurantMVC.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMVC.Controllers
{
    public class BillsController : Controller
    {
        private IBillRepository _billRepository;
        //private IProductRepository _productRepository;

        public BillsController()
        {
            _billRepository = new BillRepository();
            
        }

        public IActionResult Index()
        {
            ViewBag.bills = _billRepository.Calculate();
            return View();
        }
    }
}
