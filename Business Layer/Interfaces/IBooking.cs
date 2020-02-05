using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Enums;

namespace Business_Layer.Interfaces
{
    public interface IBooking
    {
        string BookingNr { get; set; }
        DateTime ReturnDate { get; set; }
        DateTime StartDate { get; set; }
    }
}