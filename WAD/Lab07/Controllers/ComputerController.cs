using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab07.Models;
using Lab07.DataConn;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Lab07.Controllers
{
    public class ComputerController : Controller
    {
        private ComputerContext _context;
        public ComputerController(ComputerContext context)
        {
            _context = context;
        }
        public ViewResult Index(decimal? min, decimal? max)
        {
            var list = from v
                       in _context.Computers
                       select v;
            if (min == null || max == null)
            {
                return View(list);
            }
            else
            {
                // where trả về nhiều và bên trong là biểu thức lamda
                var model = list.Where(c => c.Price >= min && c.Price <= max);
                return View(model);
            }
        }
        [HttpGet]
        public ViewResult Details(int id)
        {
            // Where phải thêm SingleofDefault
            Computer computer = _context.Computers.SingleOrDefault(c => c.Id.Equals(id));
            return View(computer);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Create")]
        public IActionResult CreateComputer(Computer computer, IFormFile file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (file.Length > 0)
                    {
                        var filePath = Path.Combine("wwwroot/images", file.FileName);
                        var stream = new FileStream(filePath, FileMode.Create);
                        file.CopyToAsync(stream);
                        computer.Photo = "images/" + file.FileName;

                        _context.Computers.Add(computer);
                        _context.SaveChanges();
                        return RedirectToAction("Index", "Computer");
                    }
                    else
                    {
                        ViewBag.Msg = "Fail";
                    }
                }
            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;
            }
            return View();
        }

        [HttpGet]
        public ViewResult UpdateOrDelete(int id)
        {
            // Where phải thêm SingleofDefault
            Computer computer = _context.Computers.SingleOrDefault(c => c.Id.Equals(id));
            return View(computer);
        }
        [HttpPost]
        public IActionResult UpdateOrDelete(string Submits, Computer computer, IFormFile file)
        {
            try
            {
                Computer comp = _context.Computers.SingleOrDefault(c => c.Id.Equals(computer.Id));
                if (comp != null)
                {
                    if (Submits.Equals("Save")) // Update
                    {
                        if (ModelState.IsValid)
                        {
                            if (file.Length > 0)
                            {
                                var filePath = Path.Combine("wwwroot/images", file.FileName);
                                var stream = new FileStream(filePath, FileMode.Create);
                                file.CopyToAsync(stream);
                                computer.Photo = "images/" + file.FileName;

                                comp.Name = computer.Name;
                                comp.Description = computer.Description;
                                comp.Price = computer.Price;
                                comp.Quantity = computer.Quantity;
                                comp.Photo = computer.Photo;

                                _context.SaveChanges();
                                return RedirectToAction("Index");
                            }
                        }

                    }
                    else //delete
                    {
                        _context.Computers.Remove(comp);
                        _context.SaveChanges();
                        return RedirectToAction("Index");
                    }
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
