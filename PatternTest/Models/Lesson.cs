using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTest.Models
{
    class Lesson
    {
        public string Name { get; set; }
        public Course Course { get; set; }

        public Lesson(string name, Course course)
        {
            Name = name;
            Course = course;
        }
    }
}
