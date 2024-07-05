using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class Operations //operations used for the interface version of the menu 
    {
        public class ShowTimeOperation : IMenuItem
        {
            public string m_Title { get; }
            public ShowTimeOperation(string i_Title)
            {
                m_Title = i_Title;
            }
            public void OnSelected()
            {
                Console.Clear();
                Console.WriteLine(DateTime.Now.ToString("T"));
                Console.ReadLine();
            }
        }

        public class ShowDateOperation : IMenuItem
        {
            public string m_Title { get; }

            public ShowDateOperation(string i_Title)
            {
                m_Title = i_Title;
            }

            public void OnSelected()
            {
                Console.Clear();
                Console.WriteLine(DateTime.Now.ToString("d"));
                Console.ReadLine();
            }
        }

        public class CountCapitals : IMenuItem
        {
            public string m_Title { get; }

            public CountCapitals(string i_Title)
            {
                m_Title = i_Title;
            }

            public void OnSelected()
            {
                Console.Clear();
                Console.WriteLine("Please enter some text:");
                string sentence = Console.ReadLine();
                int count = 0;
                foreach (char c in sentence)
                {
                    if (char.IsUpper(c))
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Number of capital letters in the sentence: {count}");
                Console.ReadLine();
            }
        }

        public class ShowVersion : IMenuItem
        {
            public string m_Title { get; }

            public ShowVersion(string i_Title)
            {
                m_Title = i_Title;
            }

            public void OnSelected()
            {
                Console.Clear();
                Console.WriteLine("Version: 24.2.4.9504");
                Console.ReadLine();
            }
        }
    }
}
