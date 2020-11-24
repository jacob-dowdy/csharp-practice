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
            // 1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            // If no one likes your post, it doesn't display anything.
            // If only one person likes your post, it displays: [Friend's Name] likes your post.
            // If two people like your post, it displays:[Friend 1] and[Friend 2] like your post.
            // If more than two people like your post, it displays:[Friend 1], [Friend 2] and[Number of Other People] others like your post.
            
            // Write a program and continuously ask the user to enter different names, 
            // until the user presses Enter(without supplying a name). 
            //Depending on the number of names provided, display a message based on the above pattern.


            List<string> nameList = new List<string>();

            while(true)
            {
                Console.WriteLine("Type a name (or hit 'Enter' to quit): ");
                var input = Console.ReadLine();

                if(String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                nameList.Add(input);
            }

            if(nameList.Count > 2)
            {
                Console.WriteLine("{0} and {1} and {2} others like your post", nameList[0], nameList[1], nameList.Count - 2);
            } else if (nameList.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post", nameList[0], nameList[1]);
            } else if (nameList.Count == 1)
            {
                Console.WriteLine("{0} likes your post", nameList[0]);
            }
            else
            {
                Console.WriteLine();
            }
            
        }
    }
}
