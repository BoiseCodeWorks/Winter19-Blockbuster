using System.Collections.Generic;

namespace blockbuster.Models
{
    class Store
    {
        public string Address { get; }
        public long PhoneNumber { get; set; }
        public List<Movie> Movies { get; private set; } = new List<Movie>();

        public void AddMovie(Movie m)
        {
            Movies.Add(m);
        }

        public void AddMovie(List<Movie> movies)
        {
            Movies.AddRange(movies);
        }

        public Store(string address, long phoneNum)
        {
            Address = address;
            PhoneNumber = phoneNum;
        }
    }
}

enum Rating
{
    G,
    PG,
    PG13,
    R,
    NR
}

enum Genre
{
    Horror,
    Thriller,
    Drama,
    Comedy,
    SciFi,
    Romance,
    Action,
    Children
}