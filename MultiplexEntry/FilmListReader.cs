using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MultiplexEntry
{
    class FilmListReader
    {
        public static void ReadList()
        {
            XmlReader reader = XmlReader.Create("FilmList.xml");
        }
    }
}
