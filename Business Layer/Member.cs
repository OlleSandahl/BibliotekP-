using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Interfaces;
using Business_Layer.Enums;

namespace Business_Layer
{
    public class Member : Person, IMember
    {
        public int MemberNr { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }

        public Member (int memberNr, string firstName, string lastName, string email, string phonenumber)
        {
            MemberNr = memberNr;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phonenumber = phonenumber;
        }
    }
}
