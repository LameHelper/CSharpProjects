using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Registration.Models
{
    public class Schedule
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Дата")]
        [Required]
        public string Date { get; set; }

        [Display(Name = "Име на лекар")]
        public string DoctorId { get; set; }
        //public virtual Doctor DoctorName  { get; set;}

        [Display(Name = "Смяна")]
        public int ShiftId { get; set; }       
        //public virtual string ShiftStart { get; set; }
        //public virtual string ShiftEnd { get; set; }
    }
}