using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Interfaces;
using Business_Layer.Enums;

namespace Business_Layer
{
    public class DataStore : IDataStore
    {
        private IInventory inventory = null;
        private IList<IMember> members;
        private IList<ILibrarian> librarians;
        private IList<IBook> books;
        private IList<IBook> Availabebooks;
        private IList<IBook> BookedBooks;
        private IList<IBooking> bookings;
        private IList<IInvoice> invoices;



    }
}
