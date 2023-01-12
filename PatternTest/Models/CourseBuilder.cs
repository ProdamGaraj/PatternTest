using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTest.Models
{
    class CourseBuilder
    {
        private Course _course;

        public CourseBuilder(string name)
        {
            _course = Course.GetInstance(name);
        }

        public CourseBuilder AddLesson(Lesson lesson) {
            _course.Lessons.Add(lesson);
            return this;
        }

        public CourseBuilder WithDescription(string description)
        {
            _course.Description = description;
            return this;
        }

        public CourseBuilder WithInstructor(string instructor)
        {
            _course.Instructor = instructor;
            return this;
        }

        public Course Build()
        {
            return _course;
        }
    }
}
