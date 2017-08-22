using CoachPage.DataAccessLayer;
using CoachPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoachPage.Controllers
{
    public class HomeController : Controller
    {
        

        //
        // GET: /Home/
        public ActionResult Index()
        {
            var db = new DataBaseContext();

            var trainer = db.Trainers.ToList();
            var posts = db.Posts.Take(3).ToList();
            var proteges = db.Proteges.ToList();

            return View();
        }
	}
}