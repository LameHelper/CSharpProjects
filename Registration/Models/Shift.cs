using System;
using System.ComponentModel.DataAnnotations;

namespace Registration.Models
{
    public class Shift
    {
        [Key]
        public int ShiftId { get; set; }
        public string ShiftStart { get; set; }
        public string ShiftEnd { get; set; }
    }
}