using System;
using System.Linq;
using System.Web.Mvc;
using InsuranceApp.Models;

namespace InsuranceApp.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Base quote
                decimal quote = 50m;

                // Calculate age
                int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
                if (DateTime.Now.DayOfYear < insuree.DateOfBirth.DayOfYear)
                    age--;

                // Age conditions
                if (age <= 18)
                    quote += 100;
                else if (age >= 19 && age <= 25)
                    quote += 50;
                else
                    quote += 25;

                // Car year
                if (insuree.CarYear < 2000)
                    quote += 25;
                else if (insuree.CarYear > 2015)
                    quote += 25;

                // Car make/model
                if (insuree.CarMake.ToLower() == "porsche")
                {
                    quote += 25;
                    if (insuree.CarModel.ToLower() == "911 carrera")
                        quote += 25;
                }

                // Speeding tickets
                quote += insuree.SpeedingTickets * 10;

                // DUI
                if (insuree.DUI)
                    quote *= 1.25m;

                // Coverage
                if (insuree.CoverageType)
                    quote *= 1.5m;

                // Save quote
                insuree.Quote = quote;
                db.Insurees.Add(insuree);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Index
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Admin
        public ActionResult Admin()
        {
            var quotes = db.Insurees.ToList();
            return View(quotes);
        }
    }
}
