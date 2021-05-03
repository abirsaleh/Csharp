using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Teacher:User
    {
        public int Salary { get; set; }

        public Teacher()
        {
               
        }
        public Teacher(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Salary(int salary)
        {
            if (salary > 0)
            {
                
            }           
        }
    }
}
