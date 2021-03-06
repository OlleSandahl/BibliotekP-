﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Enums;



namespace Business_Layer.Interfaces
{
    public interface IDataStore
    {
        IList<IBook> GetAvailabeBooks();
        IBook GetBookFromISBN(int isbn);
        IList<IBooking> GetBookings();
        IBook GetBookWithIsbn(int isbn);
        ILibrarian GetLibrarianNr(int libNr);
        IMember GetMemberNr(int memberNr);
        IList<IBook> GetReservedBooks(int bookingNr);
        IBooking ReservBook(IList<IBook> books, int libNr, int memberNr);
        IInvoice ReturnBook(int bookingNr);
    }
}