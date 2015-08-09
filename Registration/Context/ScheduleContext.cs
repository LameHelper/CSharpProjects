using Registration.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Registration.Context
{
    public class ScheduleContext : DbContext
    {
        public DbSet<DoctorSchedule> Schedules { get; set; }

    }
}