using System;
using System.Dynamic;

namespace CSharpFundamentals
{
    

    class Program
    {
        static void Main(string[] args)
        {
            // 4 - Your job is to write a program for a speed camera.
            // For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
            // Write a program that asks the user to enter the speed limit.
            // Once set, the program asks for the speed of a car.
            // If the user enters a value less than the speed limit, program should display Ok on the console.
            // If the value is above the speed limit, the program should calculate the number of demerit points.
            // For every 5km / hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
            // If the number of demerit points is above 12, the program should display License Suspended.

            Console.WriteLine("Please enter the speed limit: ");
            int speedLimit = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the speed of the car: ");
            int carSpeed = Int32.Parse(Console.ReadLine());

            int demerits = (carSpeed - speedLimit) / 5;

            if(carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else if (carSpeed > speedLimit && demerits <= 12)
            {
                Console.WriteLine(string.Format("You're speeding and you have {0} demerits", demerits));
            }
            else
            {
                Console.WriteLine("You're going too fast, hombre. Your license is suspended.");
            }

        }
    }
}
