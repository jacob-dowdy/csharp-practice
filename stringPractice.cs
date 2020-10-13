using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string firstName = "Steve";
            string lastName = "Rogers";

            string fullName = firstName + " " + lastName;
            string myFullName = string.Format("My full name is {0} {1}", firstName, lastName);

            var names = new String[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            // practicing verbatim strings
            var text = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
