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
    public class BillsController : Controller
    {
        private IBillRepository _billRepository;
        private IProductRepository _productRepository;
        private IOrderRepository _orderRepository;

        public BillsController()
        {
            _billRepository = new BillRepository();
            _productRepository = new ProductRepository();
            _orderRepository = new OrderRepository();
        }

        public IActionResult Index()
        {
            ViewBag.bills = _billRepository.Calculate();
            return View();
        }
        public IActionResult Add()
        {
            ViewBag.bills = _billRepository.Calculate();
            ViewBag.products = _productRepository.Getall();
            ViewBag.orders = _orderRepository.Getall();
            return View();
        }
        public IActionResult Update(int id)
        {
            ViewBag.products = _productRepository.Getall();
            ViewBag.orders = _orderRepository.Getall();
            var bill = _billRepository.GetById(id);
            if (bill==null)
            {
                RedirectToAction("Index");
            }
            ViewBag.bill = bill;
            return View();
        }

        public IActionResult Delete(int id)
        {
            _billRepository.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Save(Bill bill)
        {
            if (bill.Id==0)
            {
                _billRepository.Add(bill);
            }
            else
            {
                _billRepository.Update(bill);
            }
            return RedirectToAction("Index");
        }
    }
}
