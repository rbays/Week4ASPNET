using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using RobsMVCMovies.Models;

namespace RobsMVCMovies.Controllers
{
    public class HomeController : Controller
    {
        private MoviesRobEntities db = new MoviesRobEntities();
        
        // GET: Home
        public ActionResult Index()
        {
            //link query to return all movies from the database
            var movies = from m in db.Movies
                         select m;
            
            return View(movies);
        }

        public ActionResult Details(int? Id)
        {
            Movie movie = db.Movies.Find(Id);
            return View(movie);
        }

        public ActionResult Edit(int? Id)
        {
            Movie movie = db.Movies.Find(Id);
            return View(movie);
        }
        
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Title, ReleaseDate, Genre, Price")] Movie movie)
        {//using bind to specify the fields to be returned protects against overposting attacks

            db.Entry(movie).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult Delete(int? Id)
        {
            Movie movie = db.Movies.Find(Id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Delete([Bind(Include = "Id")] Movie movie)
        {
            db.Entry(movie).State = EntityState.Deleted;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}