using BlockBuster_DesignPattern.Interfaces;

namespace BlockBuster_DesignPattern
{
    public class MoviePlayer
    {
        private IPlayStrategy _playStrategy;
        private Movie _loadedMovie;

        public MoviePlayer(IPlayStrategy playStrategy, Movie movie)
        {
            _playStrategy = playStrategy;
            _loadedMovie = movie;
        }

        public void Play()
        {
            _playStrategy.Play(_loadedMovie.GetScenes());
        }
    }
}
