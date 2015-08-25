using System;
using System.ComponentModel.DataAnnotations;

namespace Registration.Models
{
    public class Shift
    {
        [Key]
        public int ShiftId { get; set; }
        [Display(Name = "Час на зпочване")]
        public string ShiftStart { get; set; }
        [Display(Name = "Час на завършване")]
        public string ShiftEnd { get; set; }
    }
}