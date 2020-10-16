using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Student1218312.Models;

namespace Student1218312.Controllers
{
    public class tbProjectController : Controller
    {
        private Context context;
        public tbProjectController(Context context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var model = context.tbProject.ToList();
            return View(model);
        }

        [HttpGet]
        public ViewResult CreateNewProject()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateNewProject(tbProject project)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    context.tbProject.Add(project);
                    context.SaveChanges();
                    return RedirectToAction("Index", "tbProject");
                }
                else
                {
                    ViewBag.Msg = "Fail";
                }
            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;
            }
            return View();
        }
        [HttpGet]
        public ViewResult UpdateOrRemove(int id)
        {
            // Where phải thêm SingleofDefault
            tbProject computer = context.tbProject.SingleOrDefault(c => c.ProjectCode.Equals(id));
            return View(computer);
        }
        [HttpPost]
        public IActionResult UpdateOrRemove(string Submits, tbProject project)
        {
            try
            {
                tbProject pro = context.tbProject.SingleOrDefault(c => c.ProjectCode.Equals(project.ProjectCode));
                if (pro != null)
                {
                    if (Submits.Equals("Update")) // Update
                    {
                        if (ModelState.IsValid)
                        {
                            pro.ClientName = project.ClientName;
                            pro.ProjectName = project.ProjectName;
                            pro.StartDate = project.StartDate;
                            pro.EndDate = project.EndDate;
                            pro.Cost = project.Cost;

                            context.SaveChanges();
                            return RedirectToAction("Index");
                        }
                    }
                    else //remove
                    {
                        context.tbProject.Remove(pro);
                        context.SaveChanges();
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
