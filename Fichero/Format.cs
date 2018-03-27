using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Fichero
{
    public abstract class Format
    {
        public abstract void Add( Alumno alumno);

        public static string GetFormat()
        {
            string valueAppConfig = ConfigurationManager.AppSettings["TypeFormat"];
            string format = Environment.GetEnvironmentVariable(valueAppConfig, EnvironmentVariableTarget.User);
            return format;
        }
    }
}
