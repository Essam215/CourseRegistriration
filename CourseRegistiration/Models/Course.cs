using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;

namespace CourseRegistiration.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        [StringLength(100)]
        public string ? Title { get; set; }
        [Range(1, 6)]
        public int Credits { get; set; }

        public List<Student> ?Students { get; set; }
    }
}
