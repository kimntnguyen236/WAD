using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab10.Models;
using Microsoft.AspNetCore.Http; // get set string

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
            return View(context.Staff.ToList());
        }
        //public IActionResult Details(Programmer programmer)
        //{
        //    return View(programmer);
        //}
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Staff staff)
        {
            try
            {
                var st = context.Staff.SingleOrDefault(s => s.StaffName.Equals(staff.StaffName));
                if (st != null)
                {
                    HttpContext.Session.SetString("name", st.StaffName);
                    if (st.Password.Equals(staff.Password))
                    {
                        if (st.Role == true)
                        {
                            return RedirectToAction("Index", "Skills");
                        }
                        else
                        {
                            return RedirectToAction("Details", "Programmers");
                        }
                    }
                    else
                    {
                        ViewBag.Msg = "Password is wrong ...";
                    }
                }
                else
                {
                    ViewBag.Msg = "Not found...";
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
