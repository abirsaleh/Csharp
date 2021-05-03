using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new Student();
            User user2 = new Student("Jalaluddin", 40); // name & age
            User user3 = new Teacher("Hasan Ahmed", 42); // name & age

            user3.Salary = 30000; // salary must be positive value, ensure that
            user2.Fees = 2000; // fees must be nonnegative, ensure that

            user.Name = "Tareq";
            Console.WriteLine(user.Name);
        }
    }
}
