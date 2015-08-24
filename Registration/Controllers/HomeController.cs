using Registration.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        public ActionResult AddNewWorkSchedule()
            
        {
            ViewBag.Doctors = db.Doctors.ToList().Select(x => new SelectListItem { Text = x.DoctorName, Value = x.DoctorId.ToString() });
            ViewBag.Shifts = db.Shifts.ToList().Select(x => new SelectListItem { Text = x.ShiftStart+"-"+x.ShiftEnd, Value = x.ShiftId.ToString() });
     
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddNewWorkSchedule(Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                db.Schedules.Add(schedule);
                db.SaveChanges();
                IList<Shift> currentShift = db.Shifts.Where(x => x.ShiftId == schedule.ShiftId).ToList();

                string dateAndTimeStart = schedule.Date + " " + currentShift[0].ShiftStart;
                DateTime shiftStart = Convert.ToDateTime(dateAndTimeStart);
                string dateAndTimeEnd = schedule.Date + " " + currentShift[0].ShiftEnd;
                DateTime shiftEnd = Convert.ToDateTime(dateAndTimeEnd);
                double minutestDifference = (shiftEnd - shiftStart).TotalMinutes;
                double examLines = minutestDifference / 20;
           
                for (int i = 0; i < examLines; i++)
                {
                    Exam exam = new Exam { DoctorId = schedule.DoctorId, ExamTime = shiftStart };
                    shiftStart = shiftStart.AddMinutes(20);
                    db.Exams.Add(exam);
                    db.SaveChanges();
                }
               
                return RedirectToAction("AddNewWorkSchedule","Home");
            }

           
            ViewBag.Doctors = db.Doctors.ToList().Select(x => new SelectListItem { Text = x.DoctorName, Value = x.DoctorId.ToString() });
            ViewBag.Shifts = db.Shifts.ToList().Select(x => new SelectListItem { Text = x.ShiftStart + "-" + x.ShiftEnd, Value = x.ShiftId.ToString() });

            return View();
        }

        [HttpGet]
        public ActionResult AddNewWorkShift()

        {          
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddNewWorkShift(Shift newShift)
        {
            if (ModelState.IsValid)
            {
                db.Shifts.Add(newShift);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            ViewBag.Doctors = db.Doctors.ToList().Select(x => new SelectListItem { Text = x.DoctorName, Value = x.DoctorId.ToString() });
            ViewBag.Shifts = db.Shifts.ToList().Select(x => new SelectListItem { Text = x.ShiftStart, Value = x.ShiftId.ToString() });
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