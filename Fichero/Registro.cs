using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Fichero
{
    public class Registro : IRegistro
    {
        private List<Alumno> Alumnos = new List<Alumno>();
        
        public static void Registrar(string formato)
        {
            Registro res = new Registro();  
            if (formato.Equals("txt")) res.RegistroTxt();
            else res.RegistroJson();
            
        }
        public void RegistroJson()
        {
            string ruta = @"C:\Users\Daniel Madrigal\Downloads\Fichero\Fichero\bin\Debug\Registro.json";
            if (File.Exists(ruta))
            {
                using (Stream st = new  FileStream("Registro.json",FileMode.Open,FileAccess.Read))
                {
                    using (StreamReader rd = new StreamReader(st))
                    {
                        string lista = rd.ReadToEnd();
                        this.Alumnos = JsonConvert.DeserializeObject<List<Alumno>>(lista);
                    }
                }
                using (Stream st = new FileStream("Registro.json", FileMode.Create, FileAccess.Write))
                {
                   
                    using (StreamWriter wrt = new StreamWriter(st))
                    {
                        this.Alumnos.Add(CrearAlumno());
                        string registro = JsonConvert.SerializeObject(Alumnos);
                        wrt.WriteLine(registro);
                    }
                }
            }
            else
            {
                using (Stream st = new FileStream("Registro.json", FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter wrt = new StreamWriter(st))
                    {
                        
                       
                        this.Alumnos.Add(CrearAlumno());
                        string registro = JsonConvert.SerializeObject(Alumnos);
                        wrt.WriteLine(registro);
                    }
                }
            }
        }

        public  void RegistroTxt()
        {
            string ruta = @"C:\Users\Daniel Madrigal\Downloads\Fichero\Fichero\bin\Debug\Registro.txt";
            if (File.Exists(ruta))
            {
                using (Stream st = new FileStream("Registro.txt",FileMode.Append,FileAccess.Write))
                {
                    using (StreamWriter wrt = new StreamWriter(st))
                    {

                        Alumno a1 = CrearAlumno();
                        string registro = String.Format(a1.Id + "," + a1.Nombre + "," + a1.Apellidos + "," + a1.Dni.ToString());
                        wrt.WriteLine(registro);
                    }
                }
            }
            else
            {
                using (Stream st = new FileStream("Registro.txt",FileMode.Create,FileAccess.Write))
                {
                    using (StreamWriter wrt = new StreamWriter(st))
                    {
                        Alumno a1 = CrearAlumno();
                        string registro = String.Format(a1.Id + "," + a1.Nombre + "," + a1.Apellidos + "," + a1.Dni.ToString());
                        wrt.WriteLine(registro);
                    }
                }
            }

        }
        public Alumno CrearAlumno()
        {
            Console.WriteLine("Escriba el identificador del Alumno:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el Nombre del Alumno:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba el Apellido del Alumno:");
            string apellido = Console.ReadLine();
            Console.WriteLine("Escriba el dni del Alumno:");
            string dni = Console.ReadLine();
            Alumno a1 = new Alumno(id, nombre, apellido, dni);
            return a1;
        }
    }
}
