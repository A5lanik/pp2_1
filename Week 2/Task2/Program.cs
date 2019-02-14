﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        public static bool IsPrime(int x) // create method that return true or false related to the entered number 
        {
            if (x <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int[] array;
            int cnt = 0;
            int j = 0;
            string lines1;
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\A5LAN\Desktop\ppp\input.txt"); // get the array of numbers from txt file
            string word = lines[0];
            array = word.Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {

                if (IsPrime(array[i]) == true)
                {

                    cnt++;

                }
            }
            int[] darr = new int[cnt];
            for (int i = 0; i < array.Length; i++)
            {

                if (IsPrime(array[i]) == true)
                {

                    darr[j] = array[i];
                    j++;
                }
            }
            lines1 = string.Join(" ", darr); // Convert the array to string
            System.IO.File.WriteAllText(@"C:\Users\A5LAN\Desktop\ppp\output.txt", lines1); // output the result

        }
    }
}
