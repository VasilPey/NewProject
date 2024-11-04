using NewProject.Models.DTO;

namespace NewProject.DL.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> AllMovies { get; }
    }
}
