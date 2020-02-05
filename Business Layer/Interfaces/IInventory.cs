using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Enums;

namespace Business_Layer.Interfaces
{
    public interface IInventory
    {
        IList<ILibrarian> GetLibrarians();
        IList<IMember> GetMembers();
        IList<IBook> GetBooks();
        IList<IBooking> GetBookings();
        IList<IInvoice> GetInvoices();
        IMember GetMemberNr(int memberNr);
        IBook GetBookWithIsbn(int isbn);
        IList<IBook> GetAvailabeBooks();
        IList<IBook> GetBookedBooks(int bookingNr);
        IBooking ReservBook(IList<IBook> books, ILibrarian librarian, IMember member);
        IInvoice ReturnBook(int bookingNr);
        IBook GetBookFromISBN(int isbn);
        





    }
}
