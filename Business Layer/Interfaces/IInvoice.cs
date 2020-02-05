using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Enums;

namespace Business_Layer.Interfaces
{
    public interface IInvoice
    {
        IBooking Booking { get; set; }
        int InvoiceNr { get; set; }
        int TotalPrice { get; set; }
    }
}