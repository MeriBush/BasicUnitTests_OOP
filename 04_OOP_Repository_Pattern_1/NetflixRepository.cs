using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Repository_Pattern_1
{
    public class NetflixRepository
    {
        /// <summary>
        /// This repository file will hold mostly methods and some fields.
        /// THERE WILL BE NO CONSOLE STATEMENTS IN THIS REPOSITORY!
        /// </summary>


        //Fields  underscore by convention, not coding requirement. They go at the top.
        //in this case, _netflixshows is a field. In this example it is also the name of my list.

        private List<NetflixShow> _netflixShows = new List<NetflixShow>();
        
        public void AddShowToList(NetflixShow show)  //method! Does stuff: adds stuff to a list
        {
            _netflixShows.Add(show);
        }

        public List<NetflixShow> GetList()
        {
            return _netflixShows;
        }

        public void RemoveShowFromList(NetflixShow show)
        {
            _netflixShows.Remove(show);
        }

        public void RemoveAllShowsWithRating(string rating)
        {
            foreach(var netflixShow in _netflixShows)
            {
                if (rating == netflixShow.Rating)
                    _netflixShows.Remove(netflixShow);
            }
        }

        public NetflixShow FindShowByName( string name)
        {
            NetflixShow show = new NetflixShow();

            foreach(NetflixShow netflixShow in _netflixShows)
            {
                if (name == netflixShow.Title)
                    show = netflixShow;
                break;
            }

            return show;
        }

        public List<NetflixShow> ListAllShowsByRating(string rating)
        {
            List<NetflixShow> listByRating = new List<NetflixShow>();

            foreach(var show in _netflixShows)
            {
                if(rating == show.Rating)
                {
                    listByRating.Add(show);
                }
            }

            return listByRating;
        }
    }
}
