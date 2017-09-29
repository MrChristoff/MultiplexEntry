using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplexEntry
{
    class FilmSelector
    {
        static string age;
        private static void GetAge()
        {
            age = Console.ReadLine();
        }

        public static void GetFilmSelection(List<Film> filmList)
        {
            GetAge();
            string filmSelection = Console.ReadLine();
            Film selectedFilm = filmList[int.Parse(filmSelection)];
            int filmRating = int.Parse(selectedFilm.Rating);
            int customerAge = int.Parse(age);
            if (CustomerOldEnoughToWatchFilm(customerAge, filmRating))
            {
                Console.WriteLine("Enjoy " + selectedFilm.Title);
            }
            else
            {
                Console.WriteLine("please make another selection");
            }
        }

        private static bool CustomerOldEnoughToWatchFilm(int customerAge, int filmRating)
        {
            return customerAge >= filmRating;
        }
    }
}
