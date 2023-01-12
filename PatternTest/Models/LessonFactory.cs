using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTest.Models
{
    class LessonFactory
    {
        public static Lesson Create(string name, string data)
        {
            return new Lesson(name, data);
        }
    }
}
