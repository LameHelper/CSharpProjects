using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Registration.Models
{
    public class DoctorSchedule
    {
        [Key]
        public int ID { get; set; }
        public string Date { get; set; }
        public string DoctorId { get; set; }
        public int Shift { get; set; }
    }
}