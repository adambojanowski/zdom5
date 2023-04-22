using System;
using System.Collections.Generic;

namespace listy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var names = new List<string>() { "Ala", "Jola" };
            foreach (string na in names)
            {
                Console.WriteLine(na);
                foreach (int nu in numbers)
                {
                    Console.WriteLine(nu);
                }
            }
        }
    }
}
