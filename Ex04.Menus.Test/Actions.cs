using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class Actions // function calls used for delegate version of the menu
    {
        internal static void ShowVersion()
        {
            Console.Clear();
            Console.WriteLine("Version: 24.2.4.9504");
            Console.ReadLine();
        }

        internal static void CountCapitals()
        {
            Console.Clear();
            Console.WriteLine("Please enter some text:");
            string sentence = Console.ReadLine();
            int count = 0;
            foreach (char c in sentence)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }
            Console.WriteLine($"Number of capital letters in the sentence: {count}");
            Console.ReadLine();
        }

        public static void ShowTime()
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.ReadLine();
        }

        public static void ShowDate()
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.ReadLine();
        }
    }
}
