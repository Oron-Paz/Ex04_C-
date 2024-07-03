using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public class MainMenu : MenuItem
    { 
       public MainMenu(string i_title) : base(i_title)
        {
            
        }

        public void Show()
        {
            OnSelected();
        }
    }
}
