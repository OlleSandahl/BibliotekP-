using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Interfaces;
using Business_Layer.Enums;

namespace Business_Layer
{
    public class Librarian : Person, ILibrarian
    {
        public int LibrNr { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Librarian(int libNr, string firstName, string lastName, string password, string role)
        {
            LibrNr = libNr;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Role = role;
        }
        
        public bool CorrectPassword(string password)
        {
            return string.Equals(Password, password);
        }
    }
}
