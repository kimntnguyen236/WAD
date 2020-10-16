using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Homework2.Controllers
{
    public class tbPeopleController : Controller
    {
        private tbPeopleContext context;
        public tbPeopleController(tbPeopleContext context)
        {
            this.context = context;
        }
        public IActionResult Index(string user)
        {
            var model = context.tbPeople.Where(c => c.Roles.Equals(false)).ToList();
            ViewBag.count = 1;
            ViewBag.user = user;
            return View(model);
        }

        // chi tiết 1 tài khoản bất kì
        public IActionResult Profile(tbPeople people) // Detail
        {
            ViewBag.user = HttpContext.Session.GetString("user");
            return View(people);
        }
        public IActionResult Menu()
        {
            return View();
        }

        // login
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password) // Lab06.Models.Account account (đối tượng)
        {
            try
            {
                tbPeople people = context.tbPeople.SingleOrDefault(a => a.Username.Equals(username)); // biểu thức lamda bên trong SingleOrDefault()
                if (people != null)
                {
                    if (people.Password.Equals(password))
                    {
                        if (people.Roles == true) // true = 1
                        {
                            ViewBag.user = username;
                            return View("Menu");
                        }
                        else
                        {
                            HttpContext.Session.SetString("user", username);
                            return RedirectToAction("Profile", people);
                        }
                    }
                    else
                    {
                        ViewBag.Msg = "Invalid password";
                    }
                }
                else
                {
                    ViewBag.Msg = "Account not found ...";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
            }
            return View();
        }
        public IActionResult Remove()
        {
            var c = context.tbPeople.Where(c => c.Roles.Equals(false)).ToList();
            return View(c);
        }
        public IActionResult Removed(string username)
        {
            try
            {
                tbPeople payment = context.tbPeople.SingleOrDefault(m => m.Username.Equals(username));
                if (payment != null)
                {
                    context.tbPeople.Remove(payment);
                    context.SaveChanges();
                    //ViewBag.Msg = "Xoa Thanh Cong";
                    return RedirectToAction("Menu");
                }
                else
                {
                    //return RedirectToAction("Index", "Payment");
                }

            }
            catch (Exception ex)
            {

                ViewBag.Msg = ex.Message;
            }
            return View();
        }
    }
}
