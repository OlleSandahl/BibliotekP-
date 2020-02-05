using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Exceptions
{
    class IncorrectStorage : Exception
    {
        public IncorrectStorage() : base ()
        {

        }
        public IncorrectStorage (string message) : base(message)
        {

        }
        public IncorrectStorage (string message, Exception inner) :base (message, inner)
        {

        }
    }
}
