using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Fichero
{
    public class FormatJson : Format
    {
        
        
        public override void AddAlumno(string path, Alumno alumno)
        {
            List<Alumno> Alumnos = new List<Alumno>();

                if (File.Exists(path))
                {
                    using (Stream st = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        using (StreamReader rd = new StreamReader(st))
                        {
                            string lista = rd.ReadToEnd();
                            Alumnos = JsonConvert.DeserializeObject<List<Alumno>>(lista);
                        }
                    }
                    using (Stream st = new FileStream(path, FileMode.Create, FileAccess.Write))
                    {

                        using (StreamWriter wrt = new StreamWriter(st))
                        {
                            Alumnos.Add(alumno);
                            string registro = JsonConvert.SerializeObject(Alumnos);
                            wrt.WriteLine(registro);
                        }
                    }
                }
                else
                {
                    using (Stream st = new FileStream(path, FileMode.Create, FileAccess.Write))
                    {
                        using (StreamWriter wrt = new StreamWriter(st))
                        {


                            Alumnos.Add(alumno);
                            string registro = JsonConvert.SerializeObject(Alumnos);
                            wrt.WriteLine(registro);
                        }
                    }
                }
            
        }
    }
}
