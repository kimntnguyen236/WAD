using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab8.Services;
using Lab8.Models;

namespace Lab8.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerService service;
        public CustomersController(ICustomerService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View(service.GetCustomers());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    service.CreateCustomer(customer);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Fail");
                }
            }
            catch (Exception e)
            {

                ModelState.AddModelError(string.Empty,e.Message);
            }
            return View();
        }
    }
}