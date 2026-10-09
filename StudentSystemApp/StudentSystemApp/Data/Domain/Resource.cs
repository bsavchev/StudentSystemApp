using System.ComponentModel.DataAnnotations;

namespace StudentSystemApp.Data.Domain
{
    public class Resource
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Url { get; set; }

        [Required]
        [MaxLength(50)]
        public string ResourceType { get; set; }
        public string CourseId { get; set; }
        public virtual Course Course { get; set; }

    }
}
