using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Fichero
{
    public class Registro 
    {

        public static Alumno CrearAlumno()
        {
            Console.WriteLine("Escriba el identificador del Alumno:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el Nombre del Alumno:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba el Apellido del Alumno:");
            string apellido = Console.ReadLine();
            Console.WriteLine("Escriba el dni del Alumno:");
            string dni = Console.ReadLine();
            Guid guid = Guid.NewGuid();
            Alumno a1 = new Alumno(guid,id, nombre, apellido, dni);
            return a1;
        }
    }
}
