using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lab04.Models;

namespace Lab04.Controllers
{
    public class StudentController : ApiController
    {
        public IHttpActionResult GetStudents() // List<Student>
        {
            var list = StudentContext.students.ToList();
            return Ok(list);
            // IHttpActionResult, HttpActionResult kiểu trả về Ok
            // ActionResult trả về View
            // nếu List<Student> trả về list
        }
    }
}
