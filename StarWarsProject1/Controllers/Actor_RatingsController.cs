using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarWarsProject1.Controllers
{
    public class Actor_RatingsController : Controller
    {
        // GET: Actor_Ratings
        public ActionResult DisplayRatings()
        {
            return View();
        }
    }
}