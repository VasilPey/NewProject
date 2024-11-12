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
        public void AddMovie(Movie movie)
        {
            MemoryDB.Movies.Add(movie);
        }

        public List<Movie> GetAllMovies()
        {
            return MemoryDB.Movies;


        }
        public Movie? GetMovieById(int id)
        {
            return MemoryDB.Movies.FirstOrDefault(m => m.Id == id);
        }
        public void DeleteMovie(int id)
        {
            Movie movie = GetMovieById(id);
            MemoryDB.Movies.Remove(movie);
        }
    }
}

