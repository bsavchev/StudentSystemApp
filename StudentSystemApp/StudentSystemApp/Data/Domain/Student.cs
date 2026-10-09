using System.ComponentModel.DataAnnotations;

namespace StudentSystemApp.Data.Domain
{
    public class Student
    {
        public int Id { get; set; }
        [Required]

        [MaxLength(100)] 
        public string Name { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public string PhoneNumber { get; set; }

        [Required]

        public DateTime RegisterOn { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        public ICollection<Homework> Homeworks { get; set; }
            = new List<Homework>();

        public ICollection<StudentCourse> StudentCourses { get; set; }
            = new List<StudentCourse>();

    }
}
