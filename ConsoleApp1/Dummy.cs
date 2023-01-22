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
            // FindPalindrome("GADACAG");
            GCDOfTwoNumbers(15, 45);
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

        static void GCDOfTwoNumbers(int num1, int num2)
        {
            // If numbers are -ve, convert them to +ve
            num1 = num1 > 0 ? num1 : -num1;
            num2 = num2 > 0 ? num2 : -num2;

            while (num1 != num2)
            {
                if(num1 > num2)
                    num1 -= num2;
                else
                    num2 -= num1;
            }

            Console.WriteLine($"GCD is {num1}");
        }
    }
}