using NewProject.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.DL.StaticDB
{
    internal static class MemoryDB
    {
        public static List<Movie> Movies = new List<Movie>()
        {
            new Movie()
            {
                Id = 1,
                Title = "The Shawshank Redemption",
                Year = 1972
            },
            new Movie()
            {
                Id = 2,
                Title = "Gundi",
                Year = 2024
            }
        };
    }
}
