using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fichero
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }

        public Alumno(int id , string nombre , string apellidos , string dni)
        {
            this.Id =id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Dni = dni;
        }
        public Alumno() { }
    }
}
