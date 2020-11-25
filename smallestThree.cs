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
            // 5 - Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10). 
            // If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
            // otherwise, display the 3 smallest numbers in the list.

            string[] elements;

            while(true)
            {
                Console.WriteLine("Please enter a list of at least 5 numbers. Each number separated by a comma: ");
                var input = Console.ReadLine();

                if(!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(",");
                    if(elements.Length >= 5)
                    {
                        break;
                    }

                }
                Console.WriteLine("Invalid List. Please try again.");
            }

            var numbers = new List<int>();
            foreach(var number in elements)
            {
                numbers.Add(Convert.ToInt32(number));
            }

            var smallestThree = new List<int>();
            while(smallestThree.Count < 3)
            {
                var min = numbers[0];
                foreach(var number in numbers)
                {
                    if (number < min)
                    {
                        min = number;
                    }
                }
                smallestThree.Add(min);
                numbers.Remove(min);
            }
            Console.WriteLine("The three smallest numbers are: ");
            foreach(var number in smallestThree)
            {
                Console.WriteLine(number);
            }

           
        }
    }
}
