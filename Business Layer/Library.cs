using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Enums;
using Business_Layer.Interfaces;
using Business_Layer.Exceptions;

namespace Business_Layer
{
    class Library
    {
        private IDataStore datastore = null;

        public Library(IDictionary<string, string> settings)
        {
            datastore = new DataStore(settings);
        }

        public ILogIn LogingIn(int libNr, string password)
        {
            ILogIn loggaIn = null;
            ILibrarian librarian = datastore.GetLibrarianNr(libNr);
            if (librarian != null && librarian.CorrectPassword(password))
                loggaIn = new LogIn(librarian);
            return loggaIn;
        }

        public IList<IBook> GetAvailabeBooks()
        {
            return datastore.GetAvailabeBooks();
        }
        public IList<IBooking> GetBookings()
        {
            return datastore.GetBookings();
        }
        public IList<IBook> GetReservedBooks(int bookingNr)
        {
            return datastore.GetReservedBooks(bookingNr);
        }
        public IBook GetBookFromISBN(int isbn)
        {
            return datastore.GetBookFromISBN(isbn);
        }
        public IInvoice ReturnBook(int bookingNr)
        {
            return datastore.ReturnBook(bookingNr);
        }
        public IBooking ReservBook(IList<IBook> books, int libNr, int memberNr)
        {
            return datastore.ReservBook(books, libNr, memberNr);
        }





        
    }
}
