using NewProject.DL.Interfaces;
using NewProject.DL.StaticDB;
using NewProject.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.DL.Repositories
{
    internal class MovieRepository : IMovieRepository
    {
        public List<Movie> GetAllMovies
        {
            return MemoryDb.movies;
            {

            }
        }
    }
}
