using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePresentation
{
    class Program
    {
        private static IStateContext context = null;
        static void Main(string[] args)
        {
            context = new StateContext();
            while (true)
                context.ShowMenu();
        }
    }
}
