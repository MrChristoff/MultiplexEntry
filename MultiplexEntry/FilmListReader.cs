using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MultiplexEntry
{
    class FilmListReader
    {
        private static List<Film> ReadList()
        {
            
            XmlSerializer serializer = new XmlSerializer(typeof(List<Film>), new XmlRootAttribute("FilmList"));
            XmlReader reader = XmlReader.Create("FilmList.xml");
            return (List<Film>)serializer.Deserialize(reader);
        }

        public static List<Film> ListOfFilms()
        {
            List<Film> filmList = new List<Film>();
            filmList = ReadList();
            return filmList;
        }
    }
}
