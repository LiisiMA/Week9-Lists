using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyWishList
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\liisi\samples\wishList";
            string fileName = @"\\wishList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> wishList = arrayFromFile.ToList<string>();

            bool loopActive = true; 

            while (loopActive)
            {
                Console.WriteLine("would you like to add a wish? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if(userInput == 'y')
                {
                    Console.WriteLine("Enter you wish:");
                    string userWish = Console.ReadLine();
                    wishList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }

            Console.Clear();

            foreach(string wish in wishList)
            {
                Console.WriteLine($"Your wish:{wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", wishList);
        }
    }
}
