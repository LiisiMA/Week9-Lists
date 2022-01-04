using System;
using System.Collections.Generic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wishList = new List<string>();

            Console.WriteLine(wishList.Count);

            wishList.Add("coffee machine");
            wishList.Add("new pair of socks");
            wishList.Add("box of chocolates");
            wishList.Add("new pillow");

            Console.WriteLine(wishList.Count);

            foreach(string wish in wishList)
            {
                Console.WriteLine(wish);
            }
        }
    }
}
