using PatternTest.Models;

namespace PatternTest
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("John Doe");
            Course course = new CourseBuilder("Math 101")
                .WithDescription("Introduction to mathematics")
                .WithInstructor("Jane Smith")
                .Build();
            Lesson lesson = LessonFactory.Create("Algebra", course);
            course.AddLesson(lesson);
            Console.WriteLine(course);
            Console.ReadLine();
        }
    }
}
