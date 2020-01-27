using System.Collections.Generic;

namespace blockbuster.Models
{
    abstract class Movie
    {
        public string Title { get; set; }
        public int RuntimeMins { get; set; }
        public Rating Rating { get; set; }
        public List<Genre> Genres { get; protected set; }
        public bool Rented { get; set; } = false;


        public Movie(string title, int runtime, Rating rating, List<Genre> genres)
        {
            Title = title;
            RuntimeMins = runtime;
            Rating = rating;
            Genres = genres;
        }
    }
}