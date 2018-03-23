using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fichero
{
    class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }

        public Alumno()
        {
            Console.WriteLine("Introduzca el Id:");
            this.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el Nombre:");
            this.Nombre = Console.ReadLine();
            Console.WriteLine("Introduzca el Apellido:");
            this.Apellidos = Console.ReadLine();
            Console.WriteLine("Introduzca el Dni:");
            this.Dni = Console.ReadLine();

        }
    }
}
