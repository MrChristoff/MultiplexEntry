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
        public void ReadList()
        {
            // using (filmListStream = new IO.MemoryStream(My.Resources.FilmList.xml)) ;
            Film film01 = new Film();
            // FileStream fs = new FileStream("FilmList.xml", FileMode.Open);
            XmlSerializer deserializer = new XmlSerializer(typeof(Film));
            XmlReader reader = XmlReader.Create("FilmList.xml");
            // TextReader reader = new StreamReader(@"C:\Users\lawrencx\Documents\Visual Studio 2015\Projects\MultiplexEntry\MultiplexEntry\FilmList.xml");
            object obj = deserializer.Deserialize(reader);
            film01 = (Film)obj;
            //reader.Close();
            Console.WriteLine(film01.Title);
            Console.WriteLine(film01.Rating);
            // https://www.youtube.com/watch?v=jbwjbbc5PjI 14m9s
        }
    }
}
