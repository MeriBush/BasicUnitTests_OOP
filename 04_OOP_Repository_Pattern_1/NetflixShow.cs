using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Repository_Pattern_1
{
    public enum GenreType
    {
        Drama = 1, Romance, Horror, Comedy, Anime, Suspense
    }

    public class NetflixShow
    {
        /// <summary>
        /// This class will only have properties (including our enum) and constructors.
        /// </summary>


        //Constructor 1
        public NetflixShow() { }  //This is a default Constructor, but I have to put it in manually after writing a constructor.

        //Constructor 2
        public NetflixShow(string title, int starRating, string rating, bool haswatched, GenreType genre)
        {
            Title = title;
            StarRating = starRating;
            Rating = rating;
            HasWatched = haswatched;
            Genre = genre;
        }

        //Properties
        public string Title { get; set; }
        public int StarRating { get; set; }
        public string Rating { get; set; }
        public bool HasWatched { get; set; }
        public GenreType Genre { get; set; }
    }
}
