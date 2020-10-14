using System;
using System.Dynamic;

namespace CSharpFundamentals
{
    

    class Program
    {
        static void Main(string[] args)
        {
            // 3- Write a program and ask the user to enter the width and height of an image. 
            // Then tell if the image is landscape or portrait.

            // a landscape image is wider than it is taller while a portrait image is taller than it is wider.

            Console.WriteLine("Enter the width of an image: ");
            int width = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of an image: ");
            int height = Int32.Parse(Console.ReadLine());

            if(width > height)
            {
                Console.WriteLine("The image is landscape orientation.");
            }
            else
            {
                Console.WriteLine("The image is portrait orientation.");
            }
        }
    }
}
