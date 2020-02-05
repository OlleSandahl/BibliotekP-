using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolePresentation;
using ConsolePresentation.interfaces;

namespace ConsolePresentation.interfaces
{
    public interface IState
    {
        void ShowMenu(IStateContext context);
    }
}
