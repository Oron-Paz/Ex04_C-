using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private IMenuItem rootItem;

        public MainMenu(string title)
        {
            rootItem = new MenuItem(title);
        }

        public void AddMenuItem(string title)
        {
            rootItem.AddSubItem(new MenuItem(title));
        }

        public void AddSubMenuItem(List<string> path, string title)
        {
            IMenuItem currentItem = rootItem;
            foreach (var itemTitle in path)
            {
                currentItem = currentItem.GetSubItems().FirstOrDefault(item => item.Title == itemTitle);
                if (currentItem == null) return;
            }
            currentItem.AddSubItem(new MenuItem(title));
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

                var subItems = menuItem.GetSubItems().ToList();
                for (int i = 0; i < subItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {subItems[i].Title}");
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
                    else if (choice > 0 && choice <= subItems.Count)
                    {
                        var selectedItem = subItems[choice - 1];
                        if (selectedItem.GetSubItems().Any())
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
