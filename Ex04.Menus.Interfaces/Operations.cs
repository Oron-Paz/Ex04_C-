using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class Operations
    {
        public class showTimeOperation : IMenuItem
        { 
            public string m_Title { get; }
            public showTimeOperation(string i_Title)
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

        public class showDateOperation : IMenuItem
        {
            public string m_Title { get; }

            public showDateOperation(string i_Title)
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

        public class countCapitals : IMenuItem
        {
            public string m_Title { get; }

            public countCapitals(string i_Title)
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

        public class showVersion : IMenuItem
        {
            public string m_Title { get; }

            public showVersion(string i_Title)
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
