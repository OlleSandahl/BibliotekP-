using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Interfaces;
using Business_Layer.Enums;

namespace Business_Layer
{
    public class LogIn : ILogIn
    {
        public ILibrarian Librarian { get; set; }

        public LogIn(ILibrarian librarian)
        {
            Librarian = librarian;
        }
    }
}
