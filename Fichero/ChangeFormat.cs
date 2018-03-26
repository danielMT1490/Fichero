using System;
using System.Threading;
using System.Configuration;

namespace Fichero
{
    class ChangeFormat
    {
        public string Change()
        {
            Console.Clear();
            string valueAppConfig = ConfigurationManager.AppSettings["TypeFormat"];
            string format = Environment.GetEnvironmentVariable(valueAppConfig, EnvironmentVariableTarget.User);
            Console.WriteLine("Escoja el Formato deseado:");
            Console.WriteLine("1.Txt" + "\n" + "2.Json" + "\n" + "3.Xml");
            int option = Convert.ToInt32(Console.ReadLine());
            switch ((TypeFormat)option)
            {
                case TypeFormat.txt:
                    Environment.SetEnvironmentVariable(valueAppConfig, "txt", EnvironmentVariableTarget.User);
                    Console.WriteLine("Cambiando formato ...");
                    Thread.Sleep(2000);
                    return "txt";

                case TypeFormat.json:
                    Environment.SetEnvironmentVariable(valueAppConfig, "json", EnvironmentVariableTarget.User);
                    Console.WriteLine("Cambiando formato ...");
                    Thread.Sleep(2000);
                    return "json";

                case TypeFormat.xml:
                    Environment.SetEnvironmentVariable(valueAppConfig, "xml", EnvironmentVariableTarget.User);
                    Console.WriteLine("Cambiando formato ...");
                    Thread.Sleep(2000);
                    return "xml";
                    
                default:
                    Console.WriteLine($"Opcion no valida , el formato sigue siendo {format}");
                    Thread.Sleep(2000);
                    return format;
                   
            }
        }
    }
}
