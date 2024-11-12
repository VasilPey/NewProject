using NewProject.Models.DTO;

namespace NewProject.DL.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        void AddMovie(Movie movie);
        Movie? GetMovieById(int id);
        void DeleteMovie(int id);
    }
}
