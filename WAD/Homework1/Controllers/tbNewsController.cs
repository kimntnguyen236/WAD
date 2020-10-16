using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Homework1.Controllers
{
    public class tbNewsController : Controller
    {
        private Context context;
        public tbNewsController(Context context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("user") == null) // chua login
            {
                return RedirectToAction("Login", "tbAdmin");
            }
            else
            {
                var model = context.tbNews.ToList();
                return View(model);
            }

        }
        public IActionResult Admin()
        {
            if (HttpContext.Session.GetString("user") == null) // chua login
            {
                return RedirectToAction("Login", "tbAdmin");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("user") == null) // chua login
            {
                return RedirectToAction("Login", "tbAdmin");
            }
            else
            {
                return View();
            }

        }
        [HttpPost]
        public IActionResult Create(tbNews News)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    context.tbNews.Add(News);
                    context.SaveChanges();
                    return RedirectToAction("Index", "tbNews");
                }
                else
                {
                    ViewBag.Msg = "Fail...";
                }
            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;
            }
            return View();
        }
    }
}
