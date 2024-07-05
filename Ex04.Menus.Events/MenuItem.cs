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
        public List<MenuItem> m_SubItems { get; }
        public Action m_Action { get; }

        public MenuItem(string i_Title, Action i_action = null)
        {
            m_Title= i_Title;
            m_Action = i_action;
            m_SubItems = new List<MenuItem>();
        }
        
        public void addSubItem(MenuItem i_Item)
        {
            m_SubItems.Add(i_Item);
        }

        public void OnSelected()
        {
            if (m_SubItems.Count > 0)
            {
                showSubMenu();
            }
            else
            {
                m_Action?.Invoke();
            }
        }

        public void showSubMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(m_Title);
                Console.WriteLine(new string('=', m_Title.Length));
                for (int i = 0; i < m_SubItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {m_SubItems[i].m_Title}");
                }
                Console.WriteLine("0. Back");
                Console.WriteLine("Please enter your choice: ");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 0 && choice <= m_SubItems.Count)
                {
                    if (choice == 0) return;
                    m_SubItems[choice - 1].OnSelected();

                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again");
                }
            }
        }

    }
}
