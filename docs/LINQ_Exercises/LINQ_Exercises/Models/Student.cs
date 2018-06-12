using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQ_Exercises.Models
{
    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int Age { get; set; }
        public int ID { get; set; }
        public List<int> Scores;
    }
}