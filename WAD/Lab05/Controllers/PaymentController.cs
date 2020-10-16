using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab05.Models;

namespace Lab05.Controllers
{
    public class PaymentController : Controller
    {
        private PaymentContext context;

        public PaymentController(PaymentContext context)
        {
            this.context = context;

        }

        public IActionResult Index(string pname) // pname lấy từ id hoặc name từ input 
        {
            var listProject = context.Payment.ToList();
            if (string.IsNullOrEmpty(pname)) // pname.Text = ""
            {
                return View(listProject);
            }
            else
            {
                // mọi phương thức đều trả về 1 trừ where 
                // equals tìm tuyệt đối
                var result = listProject.Where(p => p.ProjectName.ToLower().Contains(pname) || p.ProjectName.ToUpper().Contains(pname) || p.ProjectName.Contains(pname)); // like trong sql

                // var result = listProject.Where(p => p.ProjectName.ToLower().Contains(pname.ToLower()) || p.ProjectName.ToUpper().Contains(pname.ToUpper()) || p.ProjectName.Contains(pname)); // like trong sql

                // dùng linq
                //var result = from v
                //             in listProject
                //             where v.ProjectName.ToLower().Contains(pname.ToLower())
                //             select v;

                return View(result);


            }
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        // [ActionName("Create")] 
        // nếu phương thức dưới khác tên với trên nên phải gọi ActionName để nó hiểu và thực thi
        public IActionResult Create(Payment payment) // hai phương thức cùng tên khác tham số gọi là nạp chồng
        {
            try
            {
                if (ModelState.IsValid)
                {
                    context.Payment.Add(payment);
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