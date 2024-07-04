using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class Actions //or Operations
    {
        internal static void showVersion()
        {
            Console.Clear();
            Console.WriteLine("Version: 24.2.4.9504");
            Console.ReadLine();
        }

        internal static void countCapitals()
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

        public static void showTime()
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.ReadLine();
        }

        public static void showDate()
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.ReadLine();
        }
    }
}
