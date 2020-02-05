using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Enums;
using Business_Layer.Interfaces;



namespace Business_Layer
{
    public class InnerStorage : IInventory
    {
        private IList<ILibrarian> librariens;
        private IList<IMember> members;
        private IList<IBook> books;
        public IList<IBooking> bookings;
        private IList<IInvoice> invoices;

        public InnerStorage(IDictionary<string, string> settings)
        {
            librariens = new List<ILibrarian>()
            {
                new Librarian (1, "Gabriel", "Lundberg", "12345", "Librarien"),
                new Librarian (2, "Olle", "Sandahl", "23456", "Librarien")
            };
            members = new List<IMember>()
            {
                new Member (425, "Daniel", "Sten", "Sten@hotmail.com", "+46725559532"),
                new Member (999, "Martin", "Luthor", "Martin@gmail.com", "+4673286900")
            };
            books = new List<IBook>()
            {
                new Book ("Greta och jättarna", 258, true),
                new Book ("Klubben", 573, true),
                new Book ("Svergies medeltid", 352, true),
                new Book ("Projektledning upplaga 7", 974, true)
            };

            bookings = new List<IBooking>();
            invoices = new List<IInvoice>();

        }

        public IList<ILibrarian> GetLibrarians()
        {
            return new List<ILibrarian>(librariens);
        }

        public IList<IMember> GetMembers()
        {
            return new List<IMember>(members);
        }

        public IList<IBook> GetBooks()
        {
            return new List<IBook>(books);
        }

        public IList<IBooking> GetBookings()
        {
            return new List<IBooking>(bookings);
        }

        public IBooking GetBookings(int bookingNr)
        {

            return bookings.Where(x => x.BookingNr == bookingNr).FirstOrDefault();
        }
        public IList<IInvoice> GetInvoice()
        {
            return new List<IInvoice>(invoices);
        }
        public ILibrarian GetLibNr(int libNr)
        {
            return librariens.Where(x => x.LibrNr == libNr).FirstOrDefault();
        }
        public IMember GetMemberNr(int memberNr)
        {
            return members.Where(x => x.MemberNr == memberNr).FirstOrDefault();
        }
        public IBook GetBookIsbn(int isbn)
        {
            return books.Where(x => x.ISBN == isbn).FirstOrDefault();
        }
        public IList<IBook> GetAvailableBooks()
        {
            return books.Where(x => x.Availability == true).ToList();
        }
        public IList<IBook> GetBookedBooks(int bookingNr)
        {
            return bookings.Where(x => x.BookingNr == bookingNr && x.BookingCompleted == false).Select(x => x.Books).FirstOrDefault();
        }
        public IBooking GetBooking(int bookingNr)
        {
            return bookings.Where(x => x.BookingNr == bookingNr).FirstOrDefault();
        }
        public IBooking ReserveBook(IList<IBook> books, ILibrarian libNr, IMember memberNr)
        {
            foreach (IBook book in books)
            {
                book.Loan();
                books.Where(x => x.ISBN == book.ISBN).Select(x => { return book; }).ToList();
            }

            int bookingNr = 1;
            if (bookings.Count() != 0)
                bookingNr = bookings.Max(x => x.BookingNr) + 1;

            if (bookings.Count() != 0)
            {
                bookingNr = bookings.Max(x => x.BookingNr) + 1;
            }
            IBooking booking = new Booking(bookingNr, books, libNr, memberNr, DateTime.Now);
            bookings.Add(booking);

            return booking;
        }
        public IInvoice ReturnBook(int bookingNr)
        {
            IBooking booking = bookings.Where(x => x.BookingNr == bookingNr).FirstOrDefault();

            foreach (IBook book in booking.Books)
            {
                book.Return();
                books.Where(x => x.ISBN == book.ISBN).Select(x => { return book; }).ToList();
            }

            booking.BookingCompleted = true;
            int time = DateTime.Now.Subtract(booking.StartDate).Days;
            int totalPrice = 0;
            if (time > 21)
            {
                totalPrice = 10 * booking.Books.Count();
            }
            bookings.Where(x => x.BookingNr == booking.BookingNr).Select(x => { return booking; }).ToList();

            int invoiceNr = 1;

            if (invoices.Count() != 0)
                invoiceNr = invoices.Max(x => x.InvoiceNr) + 1;
            Invoice invoice = new Invoice(invoiceNr, booking, totalPrice);
            invoices.Add(invoice);

            return invoice;
        }

        public void RemoveBooking(int bookingNr)
        {
            IBooking booking = bookings.Where(x => x.BookingNr == bookingNr).FirstOrDefault();
            foreach (IBook book in booking.Books)
            {
                book.Return();
                books.Where(x => x.ISBN == book.ISBN).Select(x => { return book; }).ToList();
            }
            bookings.Remove(booking);
            booking.BookingCompleted = true;
        }

        public IBook GetBookByIsbn(int isbn)
        {
            return books.Where(x => x.ISBN == isbn).FirstOrDefault();
        }
    }

}


