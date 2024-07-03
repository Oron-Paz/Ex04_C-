using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;


namespace Ex04.Menus.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TestInterfacesMenu();
            TestEventsMenu();
        }

        private static void TestInterfacesMenu()
        {
            var mainMenu = new Ex04.Menus.Interfaces.MainMenu("Main Menu");
            var versionMenu = new Ex04.Menus.Interfaces.MenuItem("Version and Capitals");
            versionMenu.AddSubItem(new Ex04.Menus.Interfaces.ActionMenuItem("Show Version", ShowVersion));
            versionMenu.AddSubItem(new Ex04.Menus.Interfaces.ActionMenuItem("Count Capitals", CountCapitals));
            mainMenu.AddSubItem(versionMenu);

            var dateTimeMenu = new Ex04.Menus.Interfaces.MenuItem("Show Date/Time");
            dateTimeMenu.AddSubItem(new Ex04.Menus.Interfaces.ActionMenuItem("Show Time", ShowTime));
            dateTimeMenu.AddSubItem(new Ex04.Menus.Interfaces.ActionMenuItem("Show Date", ShowDate));
            mainMenu.AddSubItem(dateTimeMenu);

            mainMenu.Show();
        }

        private static void TestEventsMenu()
        {
            var mainMenu = new Ex04.Menus.Events.MainMenu("Main Menu");
            var versionMenu = new Ex04.Menus.Events.MenuItem("Version and Capitals");
            versionMenu.AddSubItem(new Ex04.Menus.Events.MenuItem("Show Version", ShowVersion));
            versionMenu.AddSubItem(new Ex04.Menus.Events.MenuItem("Count Capitals", CountCapitals));
            mainMenu.AddSubItem(versionMenu);

            var dateTimeMenu = new Ex04.Menus.Events.MenuItem("Show Date/Time");
            dateTimeMenu.AddSubItem(new Ex04.Menus.Events.MenuItem("Show Time", ShowTime));
            dateTimeMenu.AddSubItem(new Ex04.Menus.Events.MenuItem("Show Date", ShowDate));
            mainMenu.AddSubItem(dateTimeMenu);

            mainMenu.Show();
        }

        private static void ShowVersion()
        {
            Console.Clear();
            Console.WriteLine("App Version: 24.2.4.9504");
            Console.ReadLine();
        }

        private static void CountCapitals()
        {
            Console.Clear();
            Console.Write("Enter text: ");
            string input = Console.ReadLine();
            int capitalCount = 0;
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    capitalCount++;
                }
            }
            Console.WriteLine($"Number of capital letters: {capitalCount}");
            Console.ReadLine();
        }

        private static void ShowTime()
        {
            Console.Clear();
            Console.WriteLine($"Current Time: {DateTime.Now.ToShortTimeString()}");
            Console.ReadLine();
        }

        private static void ShowDate()
        {
            Console.Clear();
            Console.WriteLine($"Current Date: {DateTime.Now.ToShortDateString()}");
            Console.ReadLine();
        }
    }
}