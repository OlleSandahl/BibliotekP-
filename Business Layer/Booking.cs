using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Interfaces;
using Business_Layer.Enums;

namespace Business_Layer
{
    public class Booking : IBooking
    {
        public int BookingNr { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public IBook Isbn { get; set; }
        public IList<IBook> Books { get; set; }
        public ILibrarian LibNr { get; set; }
        public IMember MemberNr { get; set; }

        public bool BookingCompleted { get; set; }
        public Booking(int bookingNr, IList<IBook> books, ILibrarian libNr, IMember memberNr, DateTime startDate)
        {
            BookingNr = bookingNr;
            Books = books;
            LibNr = libNr;
            MemberNr = memberNr;
            StartDate = startDate;

            BookingCompleted = false;
        }
    }
}
