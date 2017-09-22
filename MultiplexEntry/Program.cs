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
            FilmListReader list = new FilmListReader();
            list.ReadList();
        }
    }
}
