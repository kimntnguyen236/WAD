using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Homework3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Homework3.Controllers
{
    public class ItemsController : Controller
    {
        private Context context;
        public ItemsController(Context context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listitem()
        {
            try
            {
                if (HttpContext.Session.GetString("user") == null) // chua login
                {
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    List<Items> itemsList = context.Items.ToList();
                    ViewBag.Items = itemsList;
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
            }
            return View();
        }

        public IActionResult Create(Items items, IFormFile file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (file.Length > 0)
                    {
                        var filePath = Path.Combine("wwwroot/images", file.FileName);
                        // Lưu ảnh cùng filename vô đường dẫn wwwroot/Image
                        var stream = new FileStream(filePath, FileMode.Create);
                        file.CopyToAsync(stream);

                        items.Image = file.FileName;

                        context.Items.Add(items);
                        context.SaveChanges();

                        return RedirectToAction("Listitem"); // trả về view của ....
                    }
                    else
                    {
                        ViewBag.Msg = "Fail";
                    }
                }
                else
                {
                    return View("~/Views/Shared/Error.cshtml");
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
