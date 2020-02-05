using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Enums;

namespace Business_Layer.Interfaces
{
    public interface IDataStore
    {
        ILibrarian GetLibrarianNr(int libNr);
        IMember GetMemberNr(int memberNr);
        IBook GetBookWithIsbn(int isbn);
        IList<IBook> GetAvailabeBooks();
        IList<IBook> GetBookedBooks(int bokningsNr);
        IBooking ReservBook(IList<IBook> books, int libNr, int memberNr);
        IInvoice ReturnBook(int bookingNr);
        IBook GetBookFromISBN(int isbn);
        IList<IBooking> GetBookings();
     
    }
}
