using System;

namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string palindrom = string.Empty;
            Console.WriteLine("enter ");

            palindrom = Console.ReadLine();

            var palindromChar = palindrom.ToCharArray();
            char[] newPalindromArr = { };

            int charIndex = palindrom.Length-1;
            int newCharIndex = 0;

            for (var i = palindromChar.Length; ; i-- )
            {
                newPalindromArr[newCharIndex] = palindromChar[charIndex];

                newCharIndex++;
                charIndex--;
            }
        }
    }
}
