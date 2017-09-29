using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplexEntry
{
    class MenuDisplay
    {
        public static void DisplayMenu(List<Film> filmList, string welcomeText)
        {
            WelcomeMessage(welcomeText);
            ListFilms(filmList);
            FilmSelector.GetFilmSelection(filmList);
        }
        private static void WelcomeMessage(string textToDisplay)
        {
            Console.WriteLine(textToDisplay);
            Console.WriteLine();
        }

        private static void ListFilms(List<Film> filmsToBeListed)
        {
            int count = 1;

            Console.WriteLine("*** Here are available films ***");
            Console.WriteLine();
            foreach (var film in filmsToBeListed)
            {
                Console.WriteLine("Selection number: " + count);
                Console.WriteLine("Title: " + film.Title);
                Console.WriteLine("Rating: " + film.Rating);
                Console.WriteLine();
                count++;
            }
        }

    }

}