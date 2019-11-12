using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarWarsProject1.Controllers
{
    public class Movie_ReviewsController : Controller
    {
        // GET: Movie_Reviews
        public ActionResult DisplayReviews()
        {
            return View();
        }
    }
}