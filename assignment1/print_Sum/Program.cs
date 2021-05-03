using System;

namespace print_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "123,343,45,45,47,23,58,42,96";
            var realNumbers = numbers.Split(',');
           

            int num;
            int total = 0;

            foreach(var items in realNumbers)
            {
                num = Int32.Parse(items);
                total = total+num;
            }
            Console.WriteLine($"total value:{ total}");
        }
    }
}  
