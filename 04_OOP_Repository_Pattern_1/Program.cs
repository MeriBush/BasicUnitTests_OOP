using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Repository_Pattern_1
{
    class Program
    { 
  
        /// <summary>
        /// Console statements go in here!
        /// Method calls go in here!
        /// Object creation happens here!
        /// The program runs from here!
        /// </summary>

  
        static void Main(string[] args)
        {
            NetflixShow strangerThings = new NetflixShow();
            strangerThings.Title = "Stranger Things";
            strangerThings.Genre = GenreType.Suspense;
            strangerThings.Rating = "M";
            strangerThings.StarRating = 5;
            strangerThings.HasWatched = true;

            NetflixRepository netflixRepo = new NetflixRepository();
            netflixRepo.AddShowToList(strangerThings);

            NetflixShow kimmySchmidt = new NetflixShow("The Unbreakable Kimmy Schmidt", 4, "TV-14", false, GenreType.Comedy);

            NetflixShow arrestedDev = new NetflixShow("Arrested Development", 4, "TV-14", false, GenreType.Comedy);

            NetflixShow theCrown = new NetflixShow("The Crown", 5, "TV-14", false, GenreType.Drama);

            NetflixRepository netflixRepoGroup = new NetflixRepository();
            netflixRepo.AddShowToList(kimmySchmidt);
            netflixRepo.AddShowToList(arrestedDev);
            netflixRepo.AddShowToList(theCrown);



            List<NetflixShow> shows = netflixRepo.GetList();

            foreach(NetflixShow show in shows)  //for each show in this list, print show.Title.
            {
                Console.WriteLine(show.Title);   //Print List
            }

            Console.WriteLine("                 ");

            netflixRepo.RemoveShowFromList(strangerThings);

            foreach (NetflixShow show in shows)
            {
                Console.WriteLine($"Title: {show.Title} \n" +
                    $"Rating: {show.Rating} \n" +
                    $"Star Rating: {show.StarRating} \n" +
                    $"Has Watched: {show.HasWatched} \n" +
                    $"Genre: {show.Genre} \n");
            }


            Console.WriteLine("Name the show you want to watch: ");
            string showTitle = Console.ReadLine();  //could also be var showTitle = Console.ReadLine();

            var showFoundFromFindShowByName = netflixRepo.FindShowByName(showTitle);


            Console.ReadLine();
        }


    }
}
