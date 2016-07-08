using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using RobsMVCMovies.Models;
using System.Net;

namespace RobsMVCMovies.Controllers
{
    public class HomeController : Controller
    {
        private MoviesRobEntities db = new MoviesRobEntities();
        
        // GET: Home
        public ActionResult Index(string movieGenre, string searchString)
        {
            var GenreList = new List<string>();
            var GenreQuery = from g in db.Movies
                             orderby g.Genre
                             select g.Genre;
            GenreList.AddRange(GenreQuery.Distinct());
            ViewBag.movieGenre = new SelectList(GenreList);


            var movies = from m in db.Movies
                         select m;

            if (!String.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.Genre == movieGenre);
            }

            //Title Search function
            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString));
            }
                        
            
            //link query to return all movies from the database

            return View(movies);
        }

        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(Id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(Id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Title, ReleaseDate, Genre, Price")] Movie movie)
        {//using bind to specify the fields to be returned protects against overposting attacks
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(movie);
        }


        public ActionResult Delete(int? Id)
        {
            if(Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(Id);

            if(movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        [HttpPost]
        public ActionResult Delete([Bind(Include = "Id")] Movie movie)
        {
            db.Entry(movie).State = EntityState.Deleted;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Title, ReleaseDate, Genre, Price")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Added;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movie);
        }



    }
}