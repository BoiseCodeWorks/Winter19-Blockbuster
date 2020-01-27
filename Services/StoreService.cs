using System;
using System.Collections.Generic;
using blockbuster.Models;

namespace blockbuster.Services
{
    class StoreService
    {
        private Store Store { get; set; }
        public List<Message> Messages { get; set; } = new List<Message>();

        /// <summary> Called in constructor to setup store with movies</summary>
        private void Setup()
        {
            Store = new Store("211 NE Revere Ave, Bend, OR 97701", 5413859111);
            VHS jp = new VHS(true, "Jurassic Park", 147, Rating.PG13, new List<Genre>() { Genre.Thriller, Genre.SciFi });
            VHS pagemaster = new VHS(false, "The Pagemaster", 98, Rating.PG, new List<Genre>() { Genre.Action, Genre.Children });
            VHS lotr = new VHS(true, "The Lord of the Rings: The Fellowship of the Ring - Extended Edition", 228, Rating.PG13, new List<Genre>() { Genre.Action });

            DVD dieHard = new DVD(2, true, "Die Hard", 110, Rating.R, new List<Genre>() { Genre.Action });

            Store.AddMovie(new List<Movie>() { jp, pagemaster, lotr, dieHard }); //Implicit casting
        }
        /// <summary> Puts the menu into messages </summary>
        public void PrintMenu()
        {
            string template = "Available Movies: \n";
            for (int i = 0; i < Store.Movies.Count; i++)
            {
                Movie m = Store.Movies[i];
                if (!m.Rented)
                {
                    template += $"{i + 1}) {m.Title} ({m.GetType().Name})\n";
                }
            }
            template += "\nPress a number for the movie, (Q) to quit, or (R) to return";
            Messages.Add(new Message(template, Console.ForegroundColor));
        }

        public void RentMovie(int selection)
        {
            if (selection < 0 || selection > Store.Movies.Count || Store.Movies[selection].Rented)
            {
                Messages.Add(new Message("Invalid Number", ConsoleColor.Red));
                return;
            }
            Store.Movies[selection].Rented = true;
            Messages.Add(new Message("Enjoy your movie", Console.ForegroundColor));
        }
        public void ReturnMovie()
        {

        }

        public StoreService()
        {
            Setup();
        }

    }
}