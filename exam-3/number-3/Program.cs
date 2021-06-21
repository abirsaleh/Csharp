using System;

namespace number_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= input; i++)
            {
                for (int j = 2; j <= input; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write(", "+i);
                }
                isPrime = true;
            }
            Console.ReadKey();
        }
    }
}
