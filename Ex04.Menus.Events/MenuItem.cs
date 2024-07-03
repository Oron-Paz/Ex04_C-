using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public class MenuItem
    {
        public string m_Title { get; }
        public List<MenuItem> m_subItems { get; }
        public Action m_action { get; }

        public MenuItem(string i_Title, Action i_action = null)
        {
            m_Title= i_Title;
            m_action = i_action;
            m_subItems = new List<MenuItem>();
        }
        
        public void addSubItem(MenuItem i_Item)
        {
            m_subItems.Add(i_Item);
        }

        public void OnSelected()
        {
            if (m_subItems.Count > 0)
            {
                showSubMenu();
            }
            else
            {
                m_action?.Invoke();
            }
        }

        public void showSubMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(m_Title);
                Console.WriteLine(new string('=', m_Title.Length));
                for (int i = 0; i < m_subItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}, {m_subItems[i].m_Title}");
                }
                Console.WriteLine("0. Back");
                Console.WriteLine("Please enter your choice:");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 0 && choice <= m_subItems.Count)
                {
                    if (choice == 0) return;
                    m_subItems[choice - 1].OnSelected();

                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again");
                }
            }
        }

    }
}
