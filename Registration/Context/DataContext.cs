using Registration.Models;
using System.Data.Entity;

namespace Registration.Controllers
{
    public class DataContext : DbContext
    {
        public IDbSet<Doctor> Doctors { get; set; }

        public IDbSet<Shift> Shifts { get; set; }

        public IDbSet<DoctorSchedule> Schedules { get; set; }
    }
}