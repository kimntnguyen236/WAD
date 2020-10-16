using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;
using System.Net.Http;
using Lab04WebApp.Models;

namespace Lab04WebApp.Controllers
{
    public class HomeController : Controller
    {
        private HttpClient httpClient = new HttpClient();
        private string url = "http://localhost:59880/api/Student"; // địa chỉ của api
        // GET: Home
        public ActionResult Index()
        {
            //lấy giá trị từ api xuống và lưu vào biến Result
            var res = JsonConvert.DeserializeObjectAsync<IEnumerable<Student>>(httpClient.GetStringAsync(url).Result).Result;
            return View(res);
        }
    }
}