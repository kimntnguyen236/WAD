using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Core3.Models;
//using Core3.Connect;
using Microsoft.AspNetCore.Http;
using System.IO; // Chứa Path đường dẫn.
using Microsoft.AspNetCore.Authorization;
namespace Core3.Controllers
{
    public class ComputerController : Controller
    {
        private Context context;
        public ComputerController(Context context)
        {
            this.context = context;
        }

        // Trả vê 
        [AllowAnonymous]
        //[Authorize]
        public ViewResult Index(double? min, double? max)
        {   

            var list = from c
                       in context.Computer
                       select c;
            if(min==null && max==null)
            {
                return View(list);
            }
            else
            {
                var model = list.Where(m => m.PRICE <= max && m.PRICE >= min); 
                return View(model);
            }
            
        }
        [HttpGet]
        public ViewResult Details(int id)
        {
            Computer computer = context.Computer.SingleOrDefault(c => c.ID.Equals(id));   //find co tham so
            return View(computer);
        }
        [HttpGet]
        public ViewResult UpUpdateOrDelete(int id)
        {
            Computer computer = context.Computer.SingleOrDefault(c => c.ID.Equals(id));   //find co tham so
            return View(computer);
        }
        [HttpPost]
        public IActionResult UpUpdateOrDelete(Computer computer, IFormFile file, string Submits)
        {
            try
            {
                Computer c = context.Computer.SingleOrDefault(c => c.ID.Equals(computer.ID));
                if(c!=null)
                {
                    if (Submits.Equals("Update"))//update
                    {
                        c.NAME = computer.NAME;
                        c.DESCRIPTION = computer.DESCRIPTION;
                        c.PRICE = computer.PRICE;
                        c.Quantity = computer.Quantity;

                        //photo
                        if(file is null)
                        {
                            context.SaveChanges();
                            return RedirectToAction("Index");
                        }
                        if(file.Length >0)
                        {
                            var filePath = Path.Combine("wwwroot/images", file.FileName);
                            var stream = new FileStream(filePath, FileMode.Create);
                            file.CopyToAsync(stream);
                            computer.PHOTO = "images/" + file.FileName;
                            c.PHOTO = computer.PHOTO;

                            //
                            context.SaveChanges();
                            return RedirectToAction("Index");
                        }

                        //
                       
                        
                    }
                    else//delete
                    {
                        context.Computer.Remove(c);
                        context.SaveChanges();
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    throw new Exception("Can not update or delete");
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
        public IActionResult Create(Computer computer, IFormFile file)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    if (file.Length > 0)
                    {
                        var filePath = Path.Combine("wwwroot/images", file.FileName);
                        // Lưu ảnh cùng filename dô đường dẫn wwwroot/Image
                        var stream = new FileStream(filePath, FileMode.Create);
                        file.CopyToAsync(stream);

                        computer.PHOTO = "images/" + file.FileName;

                        context.Computer.Add(computer);
                        context.SaveChanges();

                        return RedirectToAction("Index", "Computer");
                        // Phai doi lai thanh kieu IActionResult khong se bi loi return

                    }
                    else
                    {
                        ViewBag.Msg = "Fail";
                    }
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

