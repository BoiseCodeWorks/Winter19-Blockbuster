using System;
using System.Threading;
using blockbuster.Models;
using blockbuster.Services;

namespace blockbuster.Controllers
{
    class StoreController
    {
        private StoreService Service { get; set; } = new StoreService();
        private bool _running = true;

        public void Run()
        {
            while (_running)
            {
                Service.PrintMenu();
                PrintMessages();
                GetUserInput();
                PrintMessages();
            }
        }

        private void GetUserInput()
        {
            string selection = Console.ReadLine();
            Console.Clear();
            switch (selection.ToLower())
            {
                case "q":
                    _running = false;
                    break;
                case "r":
                    //Service.PrintReturns();
                    break;
                default:
                    if (int.TryParse(selection, out int num))
                    {
                        System.Console.Write("Loading");
                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(500);
                        }
                        Console.Clear();
                        Service.RentMovie(num - 1);
                    }
                    else
                    {
                        ConsoleColor start = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid selection");
                        Console.ForegroundColor = start;
                    }
                    break;

            }
            //a number (Movie)
            //Q quit
            //R return
            //anything else (Invalid Input)
        }

        public void PrintMessages()
        {
            foreach (Message message in Service.Messages)
            {
                var start = Console.ForegroundColor;
                Console.ForegroundColor = message.Color;
                System.Console.WriteLine(message.Body);
                Console.ForegroundColor = start;
            }
            Service.Messages.Clear();
        }


    }
}