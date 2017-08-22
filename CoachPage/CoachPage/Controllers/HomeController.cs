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

            var trainer = new Trainer { Name = "Karola", Surrname = "Brysz", Description = "Coś tam o mnie", PhotoFileName = "fot" };

            db.Trainers.Add(trainer);
            db.SaveChanges();

            return View();
        }
	}
}