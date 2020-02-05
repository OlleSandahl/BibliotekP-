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
            Console.WriteLine("1. Boka bok");
            Console.WriteLine("2. Återlämna bok");
            Console.WriteLine("3. Ta bort bokning");
            Console.WriteLine("4. Exit\n");
            Console.Write("Val: ");

            int choice;
            int.TryParse(Console.ReadLine(), out choice);
            
            switch (choice)
            {
                case 1:
                    context.SetState(new ReserveBookState());
                    break;
                case 2:
                    context.SetState(new ÅterlämnaBokState());
                    break;
                case 3:
                    context.SetState(new TaBortBokningState());
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    context.SetState(new HuvudMenyState());
                    break;
            }
    }
}
