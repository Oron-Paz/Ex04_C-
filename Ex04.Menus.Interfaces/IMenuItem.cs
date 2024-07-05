using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public interface IMenuItem //interface for menu item that requires both a title and a function to perform once selected
    {
        string m_Title { get; }

        void OnSelected();

    }
}
