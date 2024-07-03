using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public class MenuItem
    {
        public string Title { get; }
        public List<MenuItem> SubItems { get; }
        public Action Action { get; }

        public MenuItem(string title, Action action = null)
        {
            Title = title;
            SubItems = new List<MenuItem>();
            Action = action;
        }

        public void AddSubItem(MenuItem item)
        {
            SubItems.Add(item);
        }

        public void Execute()
        {
            if (SubItems.Count > 0)
            {
                ShowSubMenu();
            }
            else
            {
                Action?.Invoke();
            }
        }

        private void ShowSubMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(Title);
                Console.WriteLine(new string('=', Title.Length));
                for (int i = 0; i < SubItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {SubItems[i].Title}");
                }
                Console.WriteLine("0. Back");
                Console.Write("Please enter your choice: ");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 0 && choice <= SubItems.Count)
                {
                    if (choice == 0) return;
                    SubItems[choice - 1].Execute();
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.");
                }
            }
        }
    }
}
