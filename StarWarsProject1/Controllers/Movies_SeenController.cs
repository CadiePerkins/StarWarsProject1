using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarWarsProject1.Controllers
{
    public class Movies_SeenController : Controller
    {
        // GET: Movies_Seen
        public ActionResult DisplayMovies()
        {
            return View();
        }
    }
}