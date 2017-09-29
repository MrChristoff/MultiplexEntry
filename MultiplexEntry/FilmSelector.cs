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
        static string filmSelection;
        private static void GetAge()
        {
            Console.WriteLine("Please enter your age:");
            age = Console.ReadLine();
        }

        private static void GetFilmSelection()
        {
            Console.WriteLine("Please enter your film selection number:");
            filmSelection = Console.ReadLine();
        }

        public static void DisplayFilmSelection(List<Film> filmList)
        {
            GetAge();
            GetFilmSelection();

            int customerAge = int.Parse(age);
            int n = int.Parse(filmSelection) - 1;

            Film selectedFilm = filmList[n];
            int filmRating = int.Parse(selectedFilm.Rating);

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
