using Business_Layer.Interfaces;
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
        bool BookingCompleted { get; set; }
        int BookingNr { get; set; }
        IList<IBook> Books { get; set; }
        IBook Isbn { get; set; }
        ILibrarian LibNr { get; set; }
        IMember MemberNr { get; set; }
        DateTime ReturnDate { get; set; }
        DateTime StartDate { get; set; }
    }
}