using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Enums;

namespace Business_Layer.Interfaces
{
    public interface ILibrarian
    {
        int LibrNr { get; set; }
        string Password { get; set; }
        string Role { get; set; }

        bool CorrectPassword(string password);
    }
}