using StarWarsProject1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarWarsProject1.Controllers
{
    public class Movie_ReviewsController : Controller
    {
        //this is the list of movie reviews
        public static List<MovieReview> lstReviews = new List<MovieReview>();

        // GET: Movie_Reviews
        public ActionResult DisplayReviews()
        {
            return View(lstReviews);
        }

        [HttpGet] //this is the add review get method
        public ActionResult AddReview()
        {
            return View();
        }

        [HttpPost] //this is the add review post method
        public ActionResult AddReview()
        {

        }

        [HttpGet] //this is the edit review get method
        public ActionResult EditReview()
        {
            return View();
        }

        [HttpPost] //this is the edit review post method
        public ActionResult EditReview()
        {

        }
    }
}