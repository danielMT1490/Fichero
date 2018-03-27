using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fichero
{
    public class Alumno
    {
        public Guid Guid { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }

        public Alumno(Guid guid,int id , string nombre , string apellidos , string dni)
        {
            Guid = guid;
            this.Id =id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Dni = dni;
        }
        public Alumno()
        {
            Guid = Guid.NewGuid();
        }

        public override bool Equals(object obj)
        {
            var alumno = obj as Alumno;
            return alumno != null &&
                   Id == alumno.Id &&
                   Nombre == alumno.Nombre &&
                   Apellidos == alumno.Apellidos &&
                   Dni == alumno.Dni&&Guid==alumno.Guid;
        }

        public override int GetHashCode()
        {
            var hashCode = -818402288;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nombre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Apellidos);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Dni);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Guid.ToString());
            return hashCode;
        }


    }
}
