﻿using System;
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
    public class MainMenu
    {
        public void ShowMenu
        {
            Console.Clear();
            Console.WriteLine("MainMenu\n");
            Console.WriteLine("1. Boka bok");
            Console.WriteLine("2. Återlämna bok");
            Console.WriteLine("3. Ta bort bokning");
            Console.WriteLine("4. Exit\n");
            Console.Write("Val: ");

            int choice;
            int.TryParse(Console.ReadLine(), out choice);
            
            switch (choice)
            {
            case
        }
    }
}
