using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Fichero
{
    class Menu
    {
        public void GetMenu()
        {
            int option;
            string valueAppConfig = ConfigurationManager.AppSettings["TypeFormat"];
            string format = Environment.GetEnvironmentVariable(valueAppConfig, EnvironmentVariableTarget.User);
            do
            {
                Console.WriteLine($"El formato de Resgistro es {format}");
                Console.WriteLine("Que desea hacer :");
                Console.WriteLine("1.Cambiar formato"+"\n"+"2.Registrar Alumno"+"\n"+"3.Salir");
                option = Convert.ToInt32(Console.ReadLine());
                switch ((MenuOption)option)
                {
                    case MenuOption.ChangeFormat:
                        ChangeFormat cf = new ChangeFormat();
                        format=cf.Change();
                        break;
                    case MenuOption.CreateAlumno:
                        FileFactory fl = new FileFactory();
                        Format file ;

                        switch ((TypeFormat)Enum.Parse(typeof(TypeFormat), format))
                        {
                            case TypeFormat.txt:
                                 file = fl.CreateFormatTxt();
                                 file.AddAlumno("Registro.txt", Registro.CrearAlumno());
                                break;
                            case TypeFormat.json:
                                file = fl.CreateFormatJson();
                                file.AddAlumno("Registro.json", Registro.CrearAlumno());
                                break;
                            case TypeFormat.xml:
                                file = fl.CreateFormatXml();
                                file.AddAlumno("Registro.xml", Registro.CrearAlumno());
                                break;

                        }
                        break;
                    case MenuOption.Exit:
                        Console.WriteLine("Adios");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        Thread.Sleep(2000);
                        break;
                }
                Console.Clear();
            } while (option!=3);


        }
       
    }
}
