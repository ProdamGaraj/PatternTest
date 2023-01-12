using PatternTest.Models;

namespace PatternTest
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("John Doe");
            Lesson lesson = LessonFactory.Create("Algebra", "2+2=22");
            Course course = new CourseBuilder("Math 101")
                .WithDescription("Introduction to mathematics")
                .WithInstructor("Jane Smith")
                .AddLesson(lesson)
                .Build();
            Console.WriteLine(course);
            Console.ReadLine();
        }
    }
}
