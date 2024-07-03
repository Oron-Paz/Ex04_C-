using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : IMenuItem
    {
        public string Title { get; private set; }
        private List<IMenuItem> subItems = new List<IMenuItem>();

        public MenuItem(string title)
        {
            Title = title;
        }

        public IEnumerable<IMenuItem> GetSubItems()
        {
            return subItems;
        }

        public void AddSubItem(IMenuItem subItem)
        {
            subItems.Add(subItem);
        }
    }
}

