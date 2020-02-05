using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Interfaces;
using Business_Layer.Enums;

namespace Business_Layer
{
    public class Invoice : IInvoice
    {
        public int InvoiceNr { get; set; }
        public IBooking Booking { get; set; }
        public int TotalPrice { get; set; }

        public Invoice(int invoiceNr, IBooking booking, int totalPrice)
        {
            InvoiceNr = invoiceNr;
            Booking = booking;
            TotalPrice = totalPrice;
        }
    }
}
