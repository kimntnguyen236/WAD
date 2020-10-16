using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab06.Models;

namespace Lab06.Controllers
{
    public class AccountsController : Controller
    {
        private AccountContext context;
        public AccountsController(AccountContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var model = context.Account.ToList();
            return View(model);
        }

        // chi tiết 1 tài khoản bất kì
        public IActionResult Profile(Account account) // Detail
        {
            return View(account);
        }

        // login
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string accCode, string pinCode) // Lab06.Models.Account account (đối tượng)
        {
            try
            {
                Account account = context.Account.SingleOrDefault(a => a.AccountCode.Equals(accCode)); // biểu thức lamda bên trong SingleOrDefault()
                if (account != null)
                {
                    if (account.PinCode.Equals(pinCode))
                    {
                        if (account.IsAdmin == true)
                        {
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            return RedirectToAction("Profile", account);
                        }
                    }
                    else
                    {
                        ViewBag.Msg = "Invalid pincode";
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Account account)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    context.Account.Add(account);
                    context.SaveChanges();
                    ViewBag.Msg = "Congratulation!";

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
