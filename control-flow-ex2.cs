using System;
using System.Dynamic;

namespace CSharpFundamentals
{
    

    class Program
    {
        static void Main(string[] args)
        {
            // 2 - Write a program which takes two numbers from the console 
            // and displays the maximum of the two.

            Console.WriteLine("Type a number: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Type another number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine(string.Format("At {0}, num1 is larger.", num1));
            }
            else
            {
                Console.WriteLine(string.Format("At {0}, num2 is larger.", num2));
            }
        }
    }
}
