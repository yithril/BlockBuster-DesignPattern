using BlockBuster_DesignPattern.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBuster_DesignPattern
{
    public class BlockBusterVideo
    {
        public List<Movie> movieLibrary = new List<Movie>();

        public BlockBusterVideo()
        {
            BuildInitialMovieList();
        }

        public void PrintAllMovies()
        {
            for (int i = 0; i < movieLibrary.Count; i++)
            {
                Movie m = movieLibrary[i];
                string title = m.GetTitle();
                Console.WriteLine($"{i}: {title}");
            }
        }

        public void Checkout()
        {
            Console.WriteLine($"What movie would you like to watch? 0 to {movieLibrary.Count -1}");
            string input = Console.ReadLine();
            int index = int.Parse(input);

            Movie m = GetMovie(index);

            Console.WriteLine($"The movie is available in: " + string.Join(", ", m.ShowFormats()));
            Console.WriteLine("Which format do you want to watch the movie in?");
            string formatInput = Console.ReadLine();

            MoviePlayer player = CreateMoviePlayer(m, formatInput);

            player.Play();
        }

        private MoviePlayer CreateMoviePlayer(Movie movie, string format)
        {
            if(format == "DVD")
            {
                return new MoviePlayer(new DVDPlayStrategy(), movie);
            }
            else
            {
                return new MoviePlayer(new VHSPlayStrategy(), movie);
            }
        }

        private Movie GetMovie(int index)
        {
            return movieLibrary[index];
        }

        private void BuildInitialMovieList()
        {
            List<string> shrekScenes = new List<string>() { "What are you doing in my swamp", "Shrek meets Donkey", "Castle scene", "Dragon fight scene" };
            List<string> meanGirls = new List<string>() { "First day at school", "You must wear pink on Wednesdays", "Riot scene", "Who's afraid of Regina?" };
            List<string> dieHardScenes = new List<string>() { "Plane scene", "Snape takes over the building", "John McLane sneaks around", "Shoot out by the vault" };
            List<string> lordOfTheRingsScenes = new List<string>() { "Hobbiton", "Fireworks", "Mines of Moria", "Orcs attack" };

            Movie shrekMovie = new Movie("Shrek", shrekScenes, new List<string>() { "DVD" });
            Movie meanGirlsMovie = new Movie("Mean Girls", meanGirls, new List<string>() { "DVD", "VHS" });
            Movie dieHardMovie = new Movie("Die Hard", dieHardScenes, new List<string>() { "DVD", "VHS" });
            Movie lordOfTheRingsMovie = new Movie("Lord of the Rings", lordOfTheRingsScenes, new List<string>() { "VHS" });

            movieLibrary.Add(shrekMovie);
            movieLibrary.Add(meanGirlsMovie);
            movieLibrary.Add(dieHardMovie);
            movieLibrary.Add(lordOfTheRingsMovie);
        }
    }
}
