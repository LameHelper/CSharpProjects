using System;
using System.ComponentModel.DataAnnotations;

namespace Registration.Controllers
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public DateTime ExamTime { get; set; }
        public int PatientId { get; set; }
    }
}