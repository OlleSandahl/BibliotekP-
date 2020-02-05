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
    public class MainMenu : IState
    {
        public void ShowMenu(IStateContext context)
        {
            Console.Clear();
            Console.WriteLine("MainMenu\n");
            Console.WriteLine("1. Reserve book/s");
            Console.WriteLine("2. Return book/s");
            Console.WriteLine("3. Exit\n");
            Console.Write("Choice: ");

            int choice;
            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    context.SetState(new ReserveBookState());
                    break;
                case 2:
                    context.SetState(new ReturnBook());
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    context.SetState(new MainMenu());
                    break;
            }
        }
    }
}
