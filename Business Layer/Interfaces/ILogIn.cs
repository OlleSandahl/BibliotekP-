using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Enums;
using Business_Layer.Interfaces;

namespace Business_Layer
{
    public interface ILogIn
    {
        ILibrarian Librarian { get; set; }
    }
}