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
                    return  ft =CreateFormatTxt();
                case TypeFormat.json:
                    return ft=CreateFormatJson();
                case TypeFormat.xml:
                    return ft=CreateFormatXml();

            }
            return ft = null;
        }
        
        public override Format CreateFormatJson()
        {
            return new FormatJson();
        }

        public override Format CreateFormatTxt()
        {
            return new FormatTxt();
        }

        public override Format CreateFormatXml()
        {
            return new FormatXml();
        }
    }
}
