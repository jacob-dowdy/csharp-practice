// Write a program and ask the user to enter a number. The number should be between 1 to 10. 
// If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".

using System;
using System.Dynamic;

namespace CSharpFundamentals
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 10: ");
            int userNum = Int32.Parse(Console.ReadLine());

            if (userNum <= 10 && userNum >= 1)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
