using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Threading.Tasks;

namespace Fichero
{
    public class FormatXml : Format
    {
        public override void AddAlumno(string path, Alumno alumno)
        {
            List<Alumno> alumnos = new List<Alumno>();

            if (File.Exists(path))
            {
               
                XmlSerializer xSeriz = new XmlSerializer(typeof(List<Alumno>));
                using (StreamReader r = new StreamReader(path))
                {
                    String xml = r.ReadToEnd();
                    StringReader stringReader = new StringReader(xml);
                    alumnos = (List<Alumno>)xSeriz.Deserialize(stringReader);
                    alumnos.Add(alumno);
                }

                using (FileStream fs1 = new FileStream(path, FileMode.Open))
                    xSeriz.Serialize(fs1, alumnos);
            }
            else
            {
                XmlSerializer xSeriz = new XmlSerializer(typeof(List<Alumno>));
                FileStream fs1 = new FileStream(path, FileMode.Create);
                alumnos.Add(alumno);
                xSeriz.Serialize(fs1, alumnos);
            }
        }
    }
}
