using System.Collections.Generic;

namespace blockbuster.Models
{
    class VHS : Movie
    {
        public bool IsRewound { get; set; }

        public VHS(bool isRewound, string title, int runtime, Rating rating, List<Genre> genres) : base(title, runtime, rating, genres)
        {
            IsRewound = isRewound;
        }
    }
}



