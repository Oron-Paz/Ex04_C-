using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class  OperationItem : MenuItem
    {
        private readonly Action m_action;

        public OperationItem(string i_Title, Action i_action) : base(i_Title)
        {
            m_action = i_action;
        }

        public override void OnSelected()
        {
            m_action.Invoke();
        }
    }
}
