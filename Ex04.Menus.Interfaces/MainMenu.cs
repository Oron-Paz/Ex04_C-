using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private MenuItem rootItem;

        public MainMenu(string title)
        {
            rootItem = new MenuItem(title);
        }

        public void AddMenuItem(string title)
        {
            rootItem.SubItems.Add(new MenuItem(title));
        }

        public void AddSubMenuItem(List<string> path, string title)
        {
            MenuItem currentItem = rootItem;
            foreach (var itemTitle in path)
            {
                currentItem = (MenuItem)currentItem.SubItems.Find(item => item.Title == itemTitle);
                if (currentItem == null) return;
            }
            currentItem.SubItems.Add(new MenuItem(title));
        }

        public void Show()
        {
            ShowMenu(rootItem);
        }

        private void ShowMenu(IMenuItem menuItem)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(menuItem.Title);
                Console.WriteLine(new string('=', menuItem.Title.Length));

                for (int i = 0; i < menuItem.SubItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {menuItem.SubItems[i].Title}");
                }

                Console.WriteLine(menuItem == rootItem ? "0. Exit" : "0. Back");
                Console.Write("Please enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 0)
                    {
                        if (menuItem == rootItem) return;
                        else break;
                    }
                    else if (choice > 0 && choice <= menuItem.SubItems.Count)
                    {
                        var selectedItem = menuItem.SubItems[choice - 1];
                        if (selectedItem.SubItems.Count > 0)
                        {
                            ShowMenu(selectedItem);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"You selected: {selectedItem.Title}");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
    }
}
