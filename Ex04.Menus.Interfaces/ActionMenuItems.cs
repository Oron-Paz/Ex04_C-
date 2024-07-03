using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class ActionMenuItem : MenuItem
    {
        private readonly Action _action;

        public ActionMenuItem(string title, Action action) : base(title)
        {
            _action = action;
        }

        public override void Execute()
        {
            _action.Invoke();
        }
    }
}
