using NewProject.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.BL.Interfaces
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        void AddMovie(Movie movie);

        Movie GetMovieById(int id);
    }

}
