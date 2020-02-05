using Business_Layer.Interfaces;
using ConsolePresentation.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolePresentation;

namespace ConsolePresentation
{
    interface IStateContext
    {
        ILibrary Library { get; set; }
        ILogIn logIn { get; set; }

        void SetState(IState state);
        void ShowMenu();
    }
}