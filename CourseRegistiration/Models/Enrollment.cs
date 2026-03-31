using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseRegistiration.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }

        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]

        [DataType (DataType.Date)]
        public DateTime RegistrationDate { get; set; }


    }
}
