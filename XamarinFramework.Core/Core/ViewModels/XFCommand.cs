using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinFramework.Core.Core.ViewModels
{
    public class XFCommand
    {
        private Action _commandAction;

        public XFCommand(Action commandAction)
        {
            _commandAction = commandAction;
        }

        public void Execute()
        {
            _commandAction.Invoke();
        }
    }
}
