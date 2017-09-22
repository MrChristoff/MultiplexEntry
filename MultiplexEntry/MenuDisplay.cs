using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplexEntry
{
    class MenuDisplay
    {
        string welcomeText = "Welcome to Enfield Multiplex";
        public void DisplayMenu()
        {
            MenuDisplay menu = new MenuDisplay();
            menu.WelcomeMessage(welcomeText);
        }
        private void WelcomeMessage(string textToDisplay)
        {
            Console.WriteLine(textToDisplay);
            // Console.ReadLine();
        }

    }

}