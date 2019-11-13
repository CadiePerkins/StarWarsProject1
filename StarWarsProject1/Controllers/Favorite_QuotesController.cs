using StarWarsProject1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarWarsProject1.Controllers
{
    public class Favorite_QuotesController : Controller
    {
        //this is the list of quotes
        public static List<FavQuote> lstQuotes = new List<FavQuote>();

        // GET: Favorite_Quotes
        public ActionResult DisplayQuotes()
        {
            return View(lstQuotes);
        }

        [HttpGet] //this is the add quote get method
        public ActionResult AddQuote()
        {
            return View();
        }

        [HttpPost] //this is the add quote post method
        public ActionResult AddQuote()
        {

        }

        [HttpGet] //this is the edit quote get method
        public ActionResult EditQuote()
        {
            return View();
        }

        [HttpPost] //this is the edit quote post method
        public ActionResult EditQuote()
        {

        }
    }
}