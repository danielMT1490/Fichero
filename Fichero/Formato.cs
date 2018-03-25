using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Fichero
{
    public class Formato : IFormato
    {
        public enum Cambio { Si=1,No}
        public string CambiarFormato()
        {
            string formato = ConfigurationManager.AppSettings["Formato"];
            Console.WriteLine($"El formato de registro es {formato} , desea cambiarlo? "+"\n"+"1.Si"+"\n"+"2.No");
            int cambio = Convert.ToInt32(Console.ReadLine());
           
            switch ((Cambio)cambio)
            {
                case Cambio.Si:
                    if (formato.Equals("txt"))
                    {
                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config.AppSettings.Settings["Formato"].Value = "json";
                        config.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection("appSettings");
                        Console.WriteLine("Formato cambiado a json");
                        return formato = "json";
                    }
                    else
                    {
                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config.AppSettings.Settings["Formato"].Value = "txt";
                        config.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection("appSettings");
                        Console.WriteLine("Formato cambiado a txt");
                        return formato = "txt";
                    }
                   
                case Cambio.No:
                    return formato;
                default:
                    return formato;
            }
        }
    }
}
