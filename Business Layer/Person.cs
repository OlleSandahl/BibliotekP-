using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Interfaces;
using Business_Layer.Enums;

namespace Business_Layer
{
    public class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
