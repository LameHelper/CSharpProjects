using Registration.Models;
using System.Data.Entity;

namespace Registration.Controllers
{
    public class DataContext : DbContext
    {
        public IDbSet<Doctor> Doctors { get; set; }

        public IDbSet<Patient> Patients { get; set; }

        public IDbSet<Schedule> Schedules { get; set; }

        public IDbSet<Exam> Exams { get; set; }

        public IDbSet<Shift> Shifts { get; set; }

    }
}