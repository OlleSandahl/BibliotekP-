using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Enums;

namespace Business_Layer.Interfaces
{
    public interface IBook
    {
        bool Availability { get; set; }
        int ISBN { get; set; }
        string Title { get; set; }

        void Loan();
        void Return();
    }
}