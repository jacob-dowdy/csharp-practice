using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    
    // 3- Write a program and ask the user to enter 5 numbers. 
    // If a number has been previously entered, display an error message and ask the user to re-try. 
    // Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
    class Program
    {
        static void Main(string[] args)
        {

            var arr = new List<int>();

            while(arr.Count < 5)
            {
                Console.WriteLine("Please enter a number: ");
                var input = Convert.ToInt32(Console.ReadLine());

                if (arr.Contains(input))
                {
                    Console.WriteLine("You've already entered {0}. Please enter another number.", input);
                    continue;
                }

                arr.Add(input);
            }

            arr.Sort();

            foreach (var number in arr)
            {
                Console.WriteLine(number);
            }

        }
    }
}
