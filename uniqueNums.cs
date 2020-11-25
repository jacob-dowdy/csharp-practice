using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // 4 - Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
            // The list of numbers may include duplicates. Display the unique numbers that the user has entered.

            var numbers = new List<int>();

            while(true)
            {
                Console.WriteLine("Please enter a number (or type 'Quit' to exit the program): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                numbers.Add(Convert.ToInt32(input));
            }
            var uniques = new List<int>();
            foreach(var number in numbers)
            {
                if(!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
            }

            Console.WriteLine("Unique Numbers: ");
            foreach(var number in uniques)
            {
                Console.WriteLine(number);
            }

        }
    }
}
