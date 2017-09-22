using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplexEntry
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuDisplay menu = new MenuDisplay();
            menu.DisplayMenu();

            //Film film_01 = new Film();
            //film_01.Title = "BladeRunner";
            //film_01.Rating = "15";

            //Console.WriteLine(film_01.Title);
            //Console.WriteLine(film_01.Rating);
            FilmListReader.ReadList();
        }
    }
}
