using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : IMenuItem
    {
        public string Title { get; }
        public List<IMenuItem> SubItems { get; }

        public MenuItem(string title)
        {
            Title = title;
            SubItems = new List<IMenuItem>();
        }

        public void AddSubItem(IMenuItem item)
        {
            SubItems.Add(item);
        }

        public virtual void Execute()
        {
            if (SubItems.Count > 0)
            {
                ShowSubMenu();
            }
            else
            {
                Console.WriteLine("No action defined.");
            }
        }

        protected void ShowSubMenu()
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
