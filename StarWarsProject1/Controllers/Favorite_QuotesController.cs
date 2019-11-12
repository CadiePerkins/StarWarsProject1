using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarWarsProject1.Controllers
{
    public class Favorite_QuotesController : Controller
    {
        // GET: Favorite_Quotes
        public ActionResult DisplayQuotes()
        {
            return View();
        }
    }
}