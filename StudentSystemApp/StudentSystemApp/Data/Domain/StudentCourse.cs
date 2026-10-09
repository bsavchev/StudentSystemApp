using StudentSystemApp.Data.Domain;

namespace StudentSystemApp.Data.Domain
{
    public class StudentCourse
    {
        public int Id { get; set; }

        public int StudentId {get; set; }
        public virtual Student Student {get; set; }

        public int CourseID {get; set;}
        public virtual Course Course { get; set; }


    }
}
