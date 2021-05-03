using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Student:User
    {
        public int Fee { get; set; }

        public Student()
        {

        }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
