using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Interfaces;
using Business_Layer.Enums;

namespace Business_Layer
{
    public class Book : IBook
    {
        public string Title { get; set; }
        public int ISBN { get; set; }
        public bool Availability { get; set; }

        public Book(string title, int isbn, bool availability)
        {
            Title = title;
            ISBN = isbn;
            Availability = availability;
        }

        public void Loan()
        {
            Availability = false;
        }
        public void Return()
        {
            Availability = true;
        }
    }
}

