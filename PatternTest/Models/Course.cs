using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTest.Models
{
    class Course
    {
        private static Course _instance;
        public string Name { get; set; }
        public string Description { get; set; }
        public string Instructor { get; set; }
        public List<Lesson> Lessons { get; set; }

        private Course()
        {
            Lessons = new List<Lesson>();
        }

        public static Course GetInstance(string name)
        {
            if (_instance == null)
            {
                _instance = new Course();
                _instance.Name = name;
            }
            return _instance;
        }

        public void AddLesson(Lesson lesson)
        {
            Lessons.Add(lesson);
        }

        public override string ToString()
        {
            return $"Name: {Name}\nDescription: {Description}\nInstructor: {Instructor}\nLessons: {string.Join(", ", Lessons.Select(x => x.Name))}";
        }
    }
}
