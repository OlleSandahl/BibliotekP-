using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer;
using Business_Layer.Interfaces;
using System.Configuration;

namespace ConsolePresentation
{
    class StateContext
    {
        public ILogIn logIn { get; set; }
         
        

        public StateContext ()
        {
            Library = new Library(
                new Dictionary<string, string>()
           {
               { "InventoryType", ConfigurationManager.AppSettings["InventoryType"] },

           });
            SetState(new Logg)
        }
    }
}
