using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab02.Models;

namespace Lab02.Controllers
{
    public class MovieController : Controller
    {
        MovieContext db = new MovieContext();
        // GET: Movie
        public ActionResult Index()
        {
            var movielist = db.movies;
            return View(movielist);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // [ActionName("Create")] nếu không muốn viết nạp chồng
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            try
            {
                // kiểm tra tính hợp lệ dữ liệu
                if (ModelState.IsValid)
                {
                    db.movies.Add(movie);
                    db.SaveChanges();
                    ViewBag.Msg = "Congratulation!";
                }
                else
                {
                    ViewBag.Msg = "Fail!";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
            }
            
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                Movie movie = db.movies.SingleOrDefault(m => m.Id.Equals(id));
                if (movie!=null)
                {
                    db.movies.Remove(movie);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Movie");
                }
                else
                {
                    // no dothing
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var movie = db.movies.Find(id);
            return View(movie);
        }
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            try
            {
                var editMovie = db.movies.SingleOrDefault(m => m.Id.Equals(movie.Id));
                if (editMovie!=null)
                {
                    editMovie.MovieName = movie.MovieName;
                    editMovie.Genre = movie.Genre;
                    editMovie.Director = movie.Director;

                    db.SaveChanges();

                    return RedirectToAction("Index", "Movie");
                }
                else
                {
                    ViewBag.Msg = "Fail!";
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