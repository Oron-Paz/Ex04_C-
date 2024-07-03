using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public class MainMenu : MenuItem
    {
        public MainMenu(string title) : base(title)
        {
        }

        public void Show()
        {
            Execute();
        }
    }
}
