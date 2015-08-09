using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Registration.Models;

namespace Registration.Context
{
    public class DoctorContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
    }
}