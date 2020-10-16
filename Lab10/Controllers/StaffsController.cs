using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab10.Models;
using Microsoft.AspNetCore.Http;

namespace Lab10.Controllers
{
    public class StaffsController : Controller
    {
        private readonly ProgrammerContext context;
        public StaffsController(ProgrammerContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("name")==null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View(context.Staff.ToList());
            }
          
        }
        public IActionResult Details(Staff staff)
        {
            return View(staff);
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Staff staff)
        {
            try
            {
                var st = context.Staff.SingleOrDefault(s=>s.StaffName.Equals(staff.StaffName));
                if (st!=null)
                {
                    HttpContext.Session.SetString("name",st.StaffName);

                    if (st.Password.Equals(staff.Password))
                    {
                        if(st.Role==true)
                        {
                            return RedirectToAction("Index","Skills");
                        }
                        else
                        {
                            return RedirectToAction("Details", staff);
                            //return RedirectToAction("Index", "Programmers");
                        }
                    }
                    else
                    {
                        ViewBag.Msg = "Password is wrong...";
                    }
                }
                else
                {
                    ViewBag.Msg = "Staff name is not found...";
                }
            }
            catch (Exception)
            {

                throw;
            }
            return View();
        }

        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("name")!=null)
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login", "Staffs");
            }
            return View();
        }
    }
}