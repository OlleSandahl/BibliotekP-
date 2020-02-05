using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Enums;
using Business_Layer.Interfaces;
using Business_Layer.Exceptions;


namespace Business_Layer.Interfaces
{
    interface ILibrary
    {
        IList<IBook> GetAvailabeBooks();
        IBook GetBookFromISBN(int isbn);
        IList<IBooking> GetBookings();
        IList<IBook> GetReservedBooks(int bookingNr);
        ILogIn LogingIn(int libNr, string password);
        IBooking ReservBook(IList<IBook> books, int libNr, int memberNr);
        IInvoice ReturnBook(int bookingNr);
    }
}