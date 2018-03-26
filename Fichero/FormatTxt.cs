using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Fichero
{
    public class FormatTxt : Format
    {
        public override void AddAlumno(string path, Alumno alumno)
        {
            if (File.Exists(path))
            {
                using (Stream st = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter wrt = new StreamWriter(st))
                    {

                        Alumno a1 =alumno;
                        string registro = String.Format($"{alumno.Id},{alumno.Nombre},{alumno.Apellidos},{alumno.Dni}");
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
                        Alumno a1 = alumno;
                        string registro = String.Format($"{alumno.Id},{alumno.Nombre},{alumno.Apellidos},{alumno.Dni}");
                        wrt.WriteLine(registro);
                    }
                }
            }  
        }
    }
}
