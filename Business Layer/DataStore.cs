using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Interfaces;
using Business_Layer.Enums;

namespace Business_Layer
{
    public class DataStore
    {
        private IInventory inventory = null;
        private IList<IMember> members;
        private IList<ILibrarian> librarians;
        private IList<IBook> books;
        private IList<IBook> Availabebooks;
        private IList<IBook> ReservedBooks;
        private IList<IBooking> bookings;
        private IList<IInvoice> invoices;

        public DataStore(IDictionary<string, string> settings)
        {
            inventory = InventoryFactory.GetInventory(settings);
            librarians = inventory.GetLibrarians();
            members = inventory.GetMembers();
            books = inventory.GetBooks();
            Availabebooks = new List<IBook>();
            ReservedBooks = new List<IBook>();
            bookings = inventory.GetBookings();
            invoices = inventory.GetInvoices();
        }
        public ILibrarian GetLibrarianNr(int libNr)
        {
            ILibrarian librarian = librarians.Where(a => a.LibrNr == libNr).FirstOrDefault();
            if (librarian.LibrNr != libNr)
            {
                librarian = GetLibrarianNr(libNr);
                librarians.Add(librarian);
            }
            return librarian;
        }
        public IMember GetMemberNr(int memberNr)
        {
            IMember member = members.Where(m => m.MemberNr == memberNr).FirstOrDefault();
            if (member.MemberNr != memberNr)
            {
                member = GetMemberNr(memberNr);
                members.Add(member);
            }
            return member;                                                            
        }
        public IBook GetBookWithIsbn(int isbn)
        {
            IBook book = books.Where(b => b.ISBN == isbn).FirstOrDefault();
            if (book.ISBN != isbn)
            {
                book = GetBookWithIsbn(isbn);
                books.Add(book);
            }
            return book;
        }

        public IBooking ReservBook(IList<IBook> books, int libNr, int memberNr)
        {
            ILibrarian librarian = GetLibrarianNr(libNr);
            IMember member = GetMemberNr(memberNr);
            IBooking booking = inventory.ReservBook(books, librarian, member);
            bookings.Add(booking);
            return booking;
        }
        public IInvoice ReturnBook(int bookingNr)
        {
            IInvoice invoice = inventory.ReturnBook(bookingNr);
            invoices.Add(invoice);
            return invoice;
        }

        public IList<IBooking> GetBookings()
        {
            bookings = inventory.GetBookings();
            foreach (IBooking booking in bookings)
            {
                if (!bookings.Contains(booking))
                    bookings.Add(booking);
            }
            return bookings;
        }

        public IList<IBook> GetAvailabeBooks()
        {
            Availabebooks = inventory.GetAvailabeBooks();
            foreach (IBook book in Availabebooks)
            {
                if (!books.Contains(book))
                    books.Add(book);
            }
            return Availabebooks;
        }
        public IList<IBook> GetReservedBooks(int bookingNr)
        {
            ReservedBooks = inventory.GetReservedBooks(bookingNr);
            foreach (IBook book in ReservedBooks)
            {
                if (!books.Contains(book))
                    books.Add(book);
            }
            return ReservedBooks;            
        }
        public IBook GetBookFromISBN(int isbn)
        {
            return inventory.GetBookFromISBN(isbn);
        }









    }
}
