using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Interfaces;
using Business_Layer.Enums;

namespace Business_Layer
{
    public class Booking : IBooking
    {
        public string BookingNr { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ReturnDate { get; set; }


        public Booking (int bookingNr, DateTime startDate)
        {

        }
    }
}
