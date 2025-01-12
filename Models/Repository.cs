namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {

            _courses = new List<Course>()
        {
            new Course(){id = 1, title = "aspnet kursu",Image="1.img "},
            new Course() { id = 2 ,title= "php kursu",Image="1.img"},
            new Course(){ id=3 ,title="laravel kursu",Image="1.img"}

        };

        }




        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.id == id);
        }
    }

}