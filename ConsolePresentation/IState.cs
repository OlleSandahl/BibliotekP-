using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePresentation
{
    interface IState
    {
        void ShowMenu(IStateContext context);
    }
}
