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

namespace ConsolePresentation
{
    class ReturnBook : IState
    {
       public void ShowMeny(IStateContext context)
        {
            Console.Clear();
            Console.WriteLine("Return booking meny\n");

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("please input your bookingnumber: ");
            int bookingNr;
            int.TryParse(Console.ReadLine(), out bookingNr);
            IList<IBook> books = context.Library.GetReservedBooks(bookingNr);

            foreach (IBook book in books)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Isbn: {book.ISBN}\tTitle {book.Title}");
            }
            Console.WriteLine(" ");


            Console.WriteLine("Please verify your bookingnumber to complete the return: ");
            int.TryParse(Console.ReadLine(), out bookingNr);

            IInvoice invoice = context.Library.ReturnBook(bookingNr);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Invoice");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"\nInvoicenumber: {invoice.InvoiceNr}\tPrice: {invoice.TotalPrice}" + " Swedish crones");
            context.Library.ReturnBook(bookingNr);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Press enter to get to the start menu");
            Console.ReadLine();
            context.SetState(new MainMenu());



        }

       
    }
}
