using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace shoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\liisi\samples\MyShoppingList";
            string fileName = @"\\MyShoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> shoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("would you like to add something to the list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter you wish:");
                    string userWish = Console.ReadLine();
                    shoppingList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }

            Console.Clear();

            foreach (string wish in shoppingList)
            {
                Console.WriteLine($"Your list:{wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", shoppingList);

        }
    }
}
