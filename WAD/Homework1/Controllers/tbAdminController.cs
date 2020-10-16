using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Homework1.Controllers
{
    public class tbAdminController : Controller
    {
        private Context context;
        public tbAdminController(Context context)
        {
            this.context = context;
        }
        public IActionResult Index()
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
                tbAdmin account = context.tbAdmin.SingleOrDefault(a => a.UserName.Equals(username)); // biểu thức lamda bên trong SingleOrDefault()
                if (account != null)
                {
                    if (account.Password.Equals(password))
                    {
                        // tao session
                        HttpContext.Session.SetString("user", username);
                        return RedirectToAction("Admin", "tbNews");
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
    }
}
