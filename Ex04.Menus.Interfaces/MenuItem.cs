using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : IMenuItem
    {
        public string m_Title { get; }
        public List<IMenuItem> m_SubItems { get; }


        public MenuItem(string i_Title)
        {
            m_Title = i_Title;
            m_SubItems = new List<IMenuItem>();

        }

        public virtual void OnSelected()
        {
            if(m_SubItems.Count > 0) //if the Item has sub items, show the sub menu now
            {
                ShowSubMenu();
            }
            else
            {
                Console.WriteLine("No action defined");
            }
        }
        
        public virtual void ShowSubMenu() {
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
                Console.WriteLine("Please enter your choice:");
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
        public void AddSubItem(IMenuItem i_SubItem)
        {
            m_SubItems.Add(i_SubItem);
        }
    }
}
