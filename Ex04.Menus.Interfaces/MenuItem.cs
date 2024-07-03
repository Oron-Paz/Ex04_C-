using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : IMenuItem
    {
        public string Title { get; set; }
        public List<IMenuItem> SubItems { get; } = new List<IMenuItem>();

        public MenuItem(string title)
        {
            Title = title;
        }
    }  
}

