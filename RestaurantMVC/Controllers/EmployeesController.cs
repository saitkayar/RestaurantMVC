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
    public class EmployeesController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeesController()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public IActionResult Index()
        {
            ViewBag.employees = this._employeeRepository.Getall();
            return View();
        }

        public IActionResult Add()
        {

            return View();


        }

        public IActionResult Save(Employee employee)
        {
            string route = (employee.Id == 0) ? "Add" : "Update";
            if (employee.Name==null)
            {
                return RedirectToAction(route, "Please enter Name");

            }
            if (employee.SurName==null)
            {
                return RedirectToAction(route, "please enter surname");

            }
            if (employee.Id==0)
            {
                this._employeeRepository.Add(employee);

            }
            else
            {
                this._employeeRepository.Update(employee);
            }
            return RedirectToAction("Index");


        }
        public IActionResult Update(int id )
        {
            var employee = this._employeeRepository.GetById(id);
            if (employee==null)
            {
                return RedirectToAction("index");

            }
            ViewBag.employee = employee;
            return View();


        }
        public IActionResult DeleteById(int id)
        {
            this._employeeRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
