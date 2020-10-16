using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab5.Controllers
{
    public class PaymentController : Controller
    {
        private PaymentContext context;

        public PaymentController(PaymentContext context)
        {
            this.context = context;

        }
        [HttpGet]

        // cai trong () cua Index , la dung de tim kiem
        public IActionResult Index(string pname ) //ten tham so sau string lay ten giog id hoac name ben index
        {
            var listProject = context.Payment.ToList();
            if (string.IsNullOrEmpty(pname))
            {
                return View(listProject);
            }
            else
            {
                var result = listProject.Where(p=>p.ProjectName.ToLower().Contains(pname)||p.ProjectName.ToUpper().Contains(pname)|| p.ProjectName.Contains(pname));
                //p.ProjectName.ToUpper().Contains(pname.ToUpper()));
                //where tra ve nhieu, con lai tra ve 1
                // Tim tuong doi . Contains
                return View(result); // ddo du lieu ve tim kiem , con ko tim kiem thi return View()
            }
           
            
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
       // [ActionName ("Create")] su dung cai nay khi phuong thuc Create ben duoi khac ten, vi du CreatePayment()
        public IActionResult Create(Payment payment)
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

      
        public IActionResult Delete(string paymentCode)
        {
            try
            {
                Payment payment = context.Payment.SingleOrDefault(m => m.PaymentCode.Equals(paymentCode));
                if (payment != null)
                {
                    context.Payment.Remove(payment);
                    context.SaveChanges();
                    //ViewBag.Msg = "Xoa Thanh Cong";
                    return RedirectToAction("Index", "Payment");
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

        [HttpGet]
        public IActionResult Edit(string paymentCode)
        {
            var payment = context.Payment.Find(paymentCode);
            return View(payment);
        }
        [HttpPost]
        public IActionResult Edit(Payment payment)
        {
            try
            {
                Payment editpayment = context.Payment.SingleOrDefault(m => m.PaymentCode.Equals(payment));
                if (editpayment != null)
                {
                    editpayment.PaymentCode = payment.PaymentCode;
                    editpayment.ProjectCode = payment.ProjectCode;
                    editpayment.ProjectName = payment.ProjectName;
                    editpayment.Budget = payment.Budget;
                    editpayment.Fee = payment.Fee;

                    context.SaveChanges();
                    return RedirectToAction("Index", "Payment");
                    
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

    } }
