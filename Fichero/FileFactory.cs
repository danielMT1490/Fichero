using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Threading;

namespace Fichero
{
   
    public class FileFactory : TypeFactory
    {
      
        public Object Create(string format)
        {
            Format ft;
            switch ((TypeFormat)Enum.Parse(typeof(TypeFormat),format))
            {
                case TypeFormat.txt:
                    return  ft =CreateFormatTxt(format);
                case TypeFormat.json:
                    return ft=CreateFormatJson(format);
                case TypeFormat.xml:
                    return ft=CreateFormatXml(format);

            }
            return ft = null;
        }
        
        public override Format CreateFormatJson(string format)
        {
            return new FormatJson(format);
        }

        public override Format CreateFormatTxt(string format)
        {
            return new FormatTxt(format);
        }

        public override Format CreateFormatXml(string format)
        {
            return new FormatXml(format);
        }
    }
}
