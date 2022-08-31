namespace Lms.Core.Entity
{
    public class Module
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime StartTime { get; set; }

        public int ? CourseId;

        public Course Course { get; set; }
    }
}
