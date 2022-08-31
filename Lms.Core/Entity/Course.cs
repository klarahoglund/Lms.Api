namespace Lms.Core.Entity
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime StartTime { get; set; }


        public ICollection<Module> Modules  { get; set; } = new List<Module>();
    }
}
