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
            TestInterfacesMenu(); //runs the interface version of the menu
            TestEventsMenu(); //runs the actions/delegates version of the meny
        }

        private static void TestInterfacesMenu()
        {
            Ex04.Menus.Interfaces.MainMenu mainMenu = new Ex04.Menus.Interfaces.MainMenu("Main Menu");

            Ex04.Menus.Interfaces.MenuItem versionMenu = new Ex04.Menus.Interfaces.MenuItem("Version and Capitals");
            versionMenu.AddSubItem(new Ex04.Menus.Test.Operations.ShowVersion("Show Version"));
            versionMenu.AddSubItem(new Ex04.Menus.Test.Operations.CountCapitals("Count Capitals"));
            mainMenu.AddSubItem(versionMenu);

            Ex04.Menus.Interfaces.MenuItem timeAndDateMenu = new Ex04.Menus.Interfaces.MenuItem("Show Time/Date");
            timeAndDateMenu.AddSubItem(new Ex04.Menus.Test.Operations.ShowTimeOperation("Show Time"));
            timeAndDateMenu.AddSubItem(new Ex04.Menus.Test.Operations.ShowDateOperation("Show Date"));
            mainMenu.AddSubItem(timeAndDateMenu);

            mainMenu.Show();

        }

        private static void TestEventsMenu()
        {
            Ex04.Menus.Events.MainMenu mainMenu = new Ex04.Menus.Events.MainMenu("Main Menu");

            Ex04.Menus.Events.MenuItem versionMenu = new Ex04.Menus.Events.MenuItem("Version and Capitals");
            versionMenu.addSubItem(new Ex04.Menus.Events.MenuItem("Show Version", Actions.ShowVersion));
            versionMenu.addSubItem(new Ex04.Menus.Events.MenuItem("Count Capitals", Actions.CountCapitals));
            mainMenu.addSubItem(versionMenu);

            Ex04.Menus.Events.MenuItem timeAndDateMenu = new Ex04.Menus.Events.MenuItem("Show Time/Date");
            timeAndDateMenu.addSubItem(new Ex04.Menus.Events.MenuItem("Show Time", Actions.ShowTime));
            timeAndDateMenu.addSubItem(new Ex04.Menus.Events.MenuItem("Show Date", Actions.ShowDate));
            mainMenu.addSubItem(timeAndDateMenu);

            mainMenu.Show();

        }
    }
}
