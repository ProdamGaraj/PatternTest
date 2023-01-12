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
        public string Data { get; set; }

        public Lesson(string name, string data)
        {
            Name = name;
            Data = data;
        }
    }
}
