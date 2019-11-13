using StarWarsProject1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarWarsProject1.Controllers
{
    public class Movies_SeenController : Controller
    {
        //this will be the list of seen movies by the user
        public static List<SeenMovies> lstMovies = new List<SeenMovies>();

        // GET: Movies_Seen
        public ActionResult DisplayMovies()
        {
            return View(lstMovies);
        }

        [HttpGet] //this is the add movie get method
        public ActionResult AddMovie()
        {
            return View();
        }

        [HttpPost] //this is the add movie post method
        public ActionResult AddMovie()
        {
            
        }

        [HttpGet] //this is the edit movie get method
        public ActionResult EditMovie()
        {
            return View();
        }

        [HttpPost] //this is the edit movie post method
        public ActionResult EditMovie()
        {
            
        }
    }
}