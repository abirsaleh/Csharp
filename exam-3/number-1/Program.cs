using System;
using System.Linq;
using System.Text;

namespace number_1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var In1 = Console.ReadLine();
                var In2 = Console.ReadLine();

                int maxLength = Math.Max(In1.Length, In2.Length);
                int[] Num1 = new int[maxLength];
                int[] Num2 = new int[maxLength];
                int[] Diff = new int[maxLength];


                int i = maxLength - 1;

                foreach (var c in In1.Reverse())
                {
                    Num1[i--] = c - '0';
                }
                while (i >= 0)
                {
                    Num1[i--] = 0;
                }

                i = maxLength - 1;
                foreach (var c in In2.Reverse())
                {
                    Num2[i--] = c - '0';
                }
                while (i >= 0)
                {
                    Num2[i--] = 0;
                }


                int largest = 0;
                for (i = 0; i < maxLength; ++i)
                {
                    if (Num1[i] == Num2[i])
                        continue;
                    else
                    {
                        if (Num1[i] < Num2[i])
                            largest = 1;
                        else
                            largest = -1;
                        break;
                    }
                }

                if (largest == 0)
                {
                    for (i = 0; i < maxLength; ++i)
                        Diff[i] = 0;
                }
                else
                {
                    int borrow = 0;
                    for (i = maxLength - 1; i >= 0; --i)
                    {
                        int n1 = largest > 0 ? Num2[i] : Num1[i];
                        int n2 = largest > 0 ? Num1[i] : Num2[i];
                        n1 -= borrow;
                        borrow = 0;

                        while (n1 < n2)
                        {
                            borrow += 1;
                            n1 += 10;
                        }
                        Diff[i] = n1 - n2;
                    }

                }

                StringBuilder sb = new StringBuilder();
                bool leading = true;
                for (i = 0; i < maxLength; ++i)
                {
                    if (leading && Diff[i] == 0)
                        continue;
                    leading = false;
                    sb.Append((char)(Diff[i] + '0'));
                }
                if (sb.Length == 0)
                    sb.Append('0');
                var Out = sb.ToString();


                Console.WriteLine("\nThe result:");
                Console.WriteLine(Out);
            }
        }
    }
}
