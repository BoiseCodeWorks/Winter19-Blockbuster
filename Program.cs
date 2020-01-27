using System;
using System.Collections.Generic;
using blockbuster.Models;

namespace blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(@"
    ____  __    ____  ________ __ ____  __  _______________________ 
   / __ )/ /   / __ \/ ____/ //_// __ )/ / / / ___/_  __/ ____/ __ \
  / __  / /   / / / / /   / ,<  / __  / / / /\__ \ / / / __/ / /_/ /
 / /_/ / /___/ /_/ / /___/ /| |/ /_/ / /_/ /___/ // / / /___/ _, _/ 
/_____/_____/\____/\____/_/ |_/_____/\____//____//_/ /_____/_/ |_|  
                                                                    
            ");


            Store blockbuster = new Store("211 NE Revere Ave, Bend, OR 97701", 5413859111);
            VHS jp = new VHS(true, "Jurassic Park", 147, Rating.PG13, new List<Genre>() { Genre.Thriller, Genre.SciFi });
            VHS pagemaster = new VHS(false, "The Pagemaster", 98, Rating.PG, new List<Genre>() { Genre.Action, Genre.Children });
            VHS lotr = new VHS(true, "The Lord of the Rings: The Fellowship of the Ring - Extended Edition", 228, Rating.PG13, new List<Genre>() { Genre.Action });

            DVD dieHard = new DVD(2, true, "Die Hard", 110, Rating.R, new List<Genre>() { Genre.Action });

            blockbuster.AddMovie(new List<Movie>() { jp, pagemaster, lotr, dieHard }); //Implicit casting

            foreach (Movie m in blockbuster.Movies)
            {
                System.Console.Write(m.Title);
                // if (m is VHS)
                // {
                //     VHS mVHS = (VHS)m; //Explicit Casting
                //     System.Console.WriteLine(" Rewound: " + mVHS.IsRewound);
                // }
                VHS mVHS = m as VHS;
                if (mVHS != null)
                {
                    System.Console.WriteLine(" Rewound: " + mVHS.IsRewound);
                }
            }
        }
    }
}
