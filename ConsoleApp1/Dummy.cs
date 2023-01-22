using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Dummy
    {
        static void Main(string[] arg)
        {
            FindPalindrome("GADACAG");
            Console.ReadLine();
        }

        static void FindPalindrome(string input)
        {
            for (int i = 0, j = input.Length - 1; i < input.Length - 1; i++, j--)
            {
                if (input[i] == input[j])
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"Given input {input} is not palindrome");
                    return;
                }
            }

            Console.WriteLine($"Given input {input} is palindrome");
        }
    }
}