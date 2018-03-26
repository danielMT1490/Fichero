using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fichero
{
    public abstract class TypeFactory
    {
        public abstract Format CreateFormatTxt();
        public abstract Format CreateFormatJson();
        public abstract Format CreateFormatXml();

    }
}
