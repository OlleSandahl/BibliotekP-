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

namespace ConsolePresentation
{
    class StateContext : IStateContext
    {
        public ILogIn logIn { get; set; }
        public ILibrary Library { get; set; }
        private IState state = null;

        public StateContext()
        {
            Library = new Library(new Dictionary<string, string>()
           {
               {"InventoryType", ConfigurationManager.AppSettings["InventoryType"] },
               {"FolderPath", ConfigurationManager.AppSettings["FolderPath"] }

           });
            SetState(new LogInState());
        }
        public void SetState(IState state)
        {
            this.state = state;
        }
        public void ShowMenu()
        {
            state.ShowMenu(this);
        }
    }
}
