using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer;
using Business_Layer.Interfaces;
using System.Configuration;
using ConsolePresentation;
using ConsolePresentation.interfaces;
using ConsolePresentation.states;


namespace ConsolePresentation.states
{
    public class LogInState : IState
    {
        public void ShowMenu(IStateContext context)
        {
            while (context.logIn == null)
            {
                Console.Clear();
                Console.WriteLine("Bibliotek Logga In/n");


            }
        }
    }
}
