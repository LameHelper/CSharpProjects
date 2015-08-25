using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Registration.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        [Display(Name = "Име на лекар")]
        public string DoctorName { get; set; }
    }
}