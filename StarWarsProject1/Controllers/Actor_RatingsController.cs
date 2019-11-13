using StarWarsProject1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//testing 
namespace StarWarsProject1.Controllers
{
    public class Actor_RatingsController : Controller
    {
        //this is the list of actor ratings
        public static List<ActorRating> lstRatings = new List<ActorRating>();

        // GET: Actor_Ratings
        public ActionResult DisplayRatings()
        {
            return View(lstRatings);
        }

        [HttpGet] //this is the add rating get method
        public ActionResult AddRating()
        {
            return View();
        }

        [HttpPost] //this is the add rating post method
        public ActionResult AddRating()
        {

        }

        [HttpGet] //this is the edit rating get method
        public ActionResult EditRating()
        {
            return View();
        }

        [HttpPost] //this is the edit rating post method
        public ActionResult EditRating()
        {

        }
    }
}