using System.Collections.Generic;

namespace blockbuster.Models
{
    class DVD : Movie
    {
        public bool Extras { get; set; }
        public int Sides { get; set; }
        public DVD(int sides, bool extras, string title, int runtime, Rating rating, List<Genre> genres) : base(title, runtime, rating, genres)
        {
            Extras = extras;
            Sides = sides;
        }
    }
}