using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fichero
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream flujo = new FileStream("Registro.txt",FileMode.Create,FileAccess.Write);
            StreamWriter fichero = new StreamWriter(flujo);
          
            
            Alumno alumno;
            int opcion=1;
            do
            {

                Console.WriteLine("Que quiere hacer :");
                Console.WriteLine("1.Registrar alumno" + "\n" + "0.Sair");
                opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion==1)
                {
                    Console.WriteLine("Elije al formato :"+"\n"+"1.Texto"+"\n"+"2.Json"+"\n"+"3.Xml");
                    int formato = Convert.ToInt32(Console.ReadLine());
                    switch (formato)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        default:
                            alumno = new Alumno();
                            string registro = String.Format(alumno.Id + "," + alumno.Nombre + "," + alumno.Apellidos + "," + alumno.Dni.ToString());
                            fichero.WriteLine(registro);
                            break;
                    }
                   
                }

            } while (opcion!=0);

            fichero.Close();
            flujo.Close();
        }
    }
}
