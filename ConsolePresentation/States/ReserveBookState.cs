using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer;
using Business_Layer.Interfaces;
using System.Configuration;
using ConsolePresentation;
using ConsolePresentation.interfaces;
using ConsolePresentation.states;

namespace ConsolePresentation.states
{
    public class ReserveBookState : IState
    {
        IList<IBook> books = new List<IBook>();
        public void ShowMenu(IStateContext context)
        {
            Console.Clear();
            Console.WriteLine("Booking Book Menu \n");

            IList<IBook> availableBooks = context.Library.GetAvailabeBooks();
            foreach (IBook book in availableBooks)
            {
                Console.WriteLine($"ISBN: {book.ISBN}/tTitel: {book.Title}");
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("(0 = Finish booking)");
            Console.WriteLine(" ");

            int res = 0;
            do
            {
                res = Convert.ToInt32(Console.ReadLine());
                if (res != 0)
                {
                    IBook book = context.Library.GetBookFromISBN(res);
                    books.Add(book);
                    Console.WriteLine("The book with the ISBN; " + book.ISBN + " has been added your booking");
                }
            } while (res != 0);

            Console.WriteLine(" ");
            Console.WriteLine("Enter the membership number");
            int memberNr;
            int.TryParse(Console.ReadLine(), out memberNr);
            int librarienNr = context.logIn.Librarian.LibrNr;

            IBooking booking = context.Library.ReservBook(books, librarienNr, memberNr);

            Console.WriteLine(" ");
            Console.WriteLine("BookingNr: " + booking.BookingNr);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Press enter to get back to the main menu");
            Console.WriteLine();

            context.SetState(new MainMenu());

            
        }
    }
}
