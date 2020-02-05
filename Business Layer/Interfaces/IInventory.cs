using Business_Layer.Interfaces;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Enums;

namespace Business_Layer.Interfaces
{
    public interface IInventory
    {
        IList<IBook> GetAvailableBooks();
        IBook GetBookByIsbn(int isbn);
        IList<IBook> GetBookedBooks(int bookingNr);
        IBooking GetBooking(int bookingNr);
        IList<IBooking> GetBookings();
        IBooking GetBookings(int bookingNr);
        IBook GetBookIsbn(int isbn);
        IList<IBook> GetBooks();
        IList<IInvoice> GetInvoice();
        ILibrarian GetLibNr(int libNr);
        IList<ILibrarian> GetLibrarians();
        IMember GetMemberNr(int memberNr);
        IList<IMember> GetMembers();
        void RemoveBooking(int bookingNr);
        IBooking ReserveBook(IList<IBook> books, ILibrarian libNr, IMember memberNr);
        IInvoice ReturnBook(int bookingNr);
    }

}