using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Fichero
{
    class Program
    {
        public enum Opcion { Registrar=1,Salir}
       
        static void Main(string[] args)
        {
            Formato formato = new Formato();
            
            int opcion=1;
            do
            {
                Console.WriteLine("Que quiere hacer :");
                Console.WriteLine("1.Registrar alumno" + "\n" + "2.Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch ((Opcion)opcion)
                {
                    case Opcion.Registrar:
                        Registro.Registrar(formato.CambiarFormato());
                        break;
                    case Opcion.Salir:
                        break;
                    default:
                        Console.WriteLine("Escoja un aopcion correcta");
                        break;
                }
               

            } while ((Opcion)opcion!=Opcion.Salir);

        }
    }
}
