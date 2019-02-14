﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {

        private static string Reverse(string str) // create the method to reverse the string
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\A5LAN\Desktop\ppp\pal.txt");
            string word = lines[0];
            string rword = Reverse(word);
            if (word == rword)
            {
                Console.WriteLine("Yes"); // write yes if it is palindrome
            }
            else
            {
                Console.WriteLine("No"); // wtriet no if it  is not palindrome
            }


        }

    }
}
