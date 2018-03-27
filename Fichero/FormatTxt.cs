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
        public string Path { get; set; }
        public override void Add( Alumno alumno)
        {
            if (File.Exists(Path))
            {
                using (Stream st = new FileStream(Path, FileMode.Append, FileAccess.Write))
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
                using (Stream st = new FileStream(Path, FileMode.Create, FileAccess.Write))
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

        public FormatTxt(string format)
        {
            this.Path = String.Format($"Registro.{format}");
        }
    }
}
