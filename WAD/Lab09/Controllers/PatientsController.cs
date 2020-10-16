using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab09.Services;
using Lab09.Models;
using X.PagedList.Mvc;
using X.PagedList;

namespace Lab09.Controllers
{
    public class PatientsController : Controller
    {
        public readonly IPatientService patientService;
        public PatientsController(IPatientService patientService)
        {
            this.patientService = patientService;
        }
        public IActionResult Index(int? page, string pname)
        {
            int max = 4;
            int numpage = page ?? 1;

            var pList = patientService.GetPatients().OrderByDescending(p => p.PatientName).ToList().ToPagedList(numpage, max);
            if (string.IsNullOrEmpty(pname))
            {
                ViewBag.data = pList;
            }
            else
            {
                var model = patientService.GetPatients().Where(p => p.PatientName.ToUpper().Contains(pname.ToUpper())).OrderByDescending(p => p.PatientName).ToList().ToPagedList(numpage, max);
                ViewBag.data = model;
            }
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Patient pt)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    patientService.AddPatient(pt);
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewData["Msg"] = "Fail";
                }
            }
            catch (Exception ex)
            {
                ViewData["Msg"] = ex.Message;
            }
            return View();
        }

        [HttpGet]
        public IActionResult UpdateOrDelete(int id)
        {
            return View(patientService.GetPatient(id));
        }
        [HttpPost]
        public IActionResult UpdateOrDelete(string submit, Patient pa) // submit : name
        {
            try
            {
                var pt = patientService.GetPatient(pa.Id);
                if (submit.Equals("Save")) // "Save" là value
                {
                    patientService.UpdatePatient(pa);
                    return RedirectToAction("Index");
                }
                else
                {
                    patientService.RemovePatient(pa.Id);
                    return RedirectToAction("Index");
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
