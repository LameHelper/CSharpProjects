using Registration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Registration.Controllers
{
    public class HomeController : Controller
    {
        private DataContext db = new DataContext();

        public ActionResult Index()
        {                       
            return View();
        }       
        [HttpGet]
        public ActionResult CreateNewSchedule()
            
        {
            ViewBag.Doctors = db.Doctors.ToList().Select(x => new SelectListItem { Text = x.DoctorName, Value = x.DoctorId.ToString() });
            ViewBag.Shifts = db.Shifts.ToList().Select(x => new SelectListItem { Text = x.ShiftName, Value = x.ShiftId.ToString() });
            return View();
        }

        [HttpPost]
        public ActionResult CreateNewSchedule(DoctorSchedule schedule)
        {           
            ViewBag.Doctors = db.Doctors.ToList().Select(x => new SelectListItem { Text = x.DoctorName, Value = x.DoctorId.ToString() });
            ViewBag.Shifts = db.Shifts.ToList().Select(x => new SelectListItem { Text = x.ShiftName, Value = x.ShiftId.ToString() });           
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}