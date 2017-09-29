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
            MenuDisplay.DisplayMenu(
                FilmListReader.ListOfFilms(), 
                "Welcome to Enfield Multiplex"
                );
        }
    }
}
