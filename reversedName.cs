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
            //2 - Write a program and ask the user to enter their name. 
            //Use an array to reverse the name and then store the result in a new string.
            //Display the reversed name on the console.

            Console.WriteLine("Please enter your name: ");
            var input = Console.ReadLine();

            var arr = new char[input.Length];
            for (var i = input.Length; i > 0; i--)
            {
                arr[input.Length - i] = input[i - 1];
            }

            var reversedString = new String(arr);
            Console.WriteLine(reversedString);
        }
    }
}
