using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : MenuItem 
    {
         
        public MainMenu(string i_Title) : base(i_Title)
        {
            //main menu is essentially a menu item with no "parent"
        }

        public void Show() //call to display the menu starting with the root menu
        {
           OnSelected(); 
        }

    }
}
