using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Enums;
using Business_Layer.Interfaces;



namespace Business_Layer
{
    class InnerStorage
    {
        private IList<ILibrarian> librariens;
        private IList<IMember> members;
        private IList<IBook> books;
        public IList<IBooking> bookings;
        private IList<IInvoice> invoices;

        public InnerStorage (IDictionary<string, string> settings)
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
            
        }
    }


}
