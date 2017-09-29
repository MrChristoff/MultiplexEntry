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
            //TODO: refactor to handle more than one object and then return a collection
            XmlSerializer deserializer = new XmlSerializer(typeof(Film));
            XmlReader reader = XmlReader.Create("FilmList.xml");
            Film film01 = (Film)deserializer.Deserialize(reader); /* deserialized object need to be 'cast' into a Film object, thusly (Film) */
            
            // https://www.youtube.com/watch?v=jbwjbbc5PjI 14m9s
        }
    }
}
