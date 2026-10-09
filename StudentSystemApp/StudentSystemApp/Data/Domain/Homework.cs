using System.ComponentModel.DataAnnotations;

namespace StudentSystemApp.Data.Domain
{
    public class Homework
    {
        public int Id { get; set; }
        public string Content { get; set; }

        [Required]
        [MaxLength(50)]
        public string ContentType { get; set; }

        [Required]
        public DateTime SubmissionTime { get; set; }
        public string StudentId { get; set; }

        public virtual Student Student { get; set; }
        public string CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
