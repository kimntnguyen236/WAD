using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab08.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab08.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly ICustomerService _customerService;
        public OrderController(IOrderService orderService, ICustomerService customerService)
        {
            _orderService = orderService;
            _customerService = customerService;
        }
        public IActionResult Index()
        {
            return View(_orderService.GetOrders());
        }
        public IActionResult Create()
        {
            var list = _customerService.GetCustomers();
            ViewBag.cusName = new SelectList(list, "CustomerCode", "CustomerName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Models.Order newOrder)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _orderService.CreateOrder(newOrder);
                    return RedirectToAction("Index", "Orders");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Failed");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
            }
            return View();
        }
    }
}
