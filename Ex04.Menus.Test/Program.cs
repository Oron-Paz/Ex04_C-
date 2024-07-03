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
            versionMenu.addSubItem(new Ex04.Menus.Interfaces.OperationItem("Show Version", Actions.showVersion));
            versionMenu.addSubItem(new Ex04.Menus.Interfaces.OperationItem("Count Capitals", Actions.countCapitals));
            mainMenu.addSubItem(versionMenu);

            var timeAndDateMenu = new Ex04.Menus.Interfaces.MenuItem("Show Time/Date");
            timeAndDateMenu.addSubItem(new Ex04.Menus.Interfaces.OperationItem("Show Time", Actions.showTime));
            timeAndDateMenu.addSubItem(new Ex04.Menus.Interfaces.OperationItem("Show Date", Actions.showDate));
            mainMenu.addSubItem(timeAndDateMenu);

            mainMenu.Show();

        }

        private static void TestEventsMenu()
        {
            var mainMenu = new Ex04.Menus.Events.MainMenu("Main Menu");

            var versionMenu = new Ex04.Menus.Events.MenuItem("Version and Capitals");
            versionMenu.addSubItem(new Ex04.Menus.Events.MenuItem("Show Version", Actions.showVersion));
            versionMenu.addSubItem(new Ex04.Menus.Events.MenuItem("Count Capitals", Actions.countCapitals));
            mainMenu.addSubItem(versionMenu);

            var timeAndDateMenu = new Ex04.Menus.Events.MenuItem("Show Time/Date");
            timeAndDateMenu.addSubItem(new Ex04.Menus.Events.MenuItem("Show Time", Actions.showTime));
            timeAndDateMenu.addSubItem(new Ex04.Menus.Events.MenuItem("Show Date", Actions.showDate));
            mainMenu.addSubItem(timeAndDateMenu);

            mainMenu.Show();

        }
    }
}
