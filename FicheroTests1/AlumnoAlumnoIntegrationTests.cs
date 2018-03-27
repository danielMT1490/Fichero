using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fichero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fichero.Tests
{
    [TestClass()]
    public class AlumnoAlumnoIntegrationTests
    {
        [TestMethod()]
        public void AlumnoConstructorTest()
        {
            Alumno al1 = new Alumno();
            al1.Id = 1;
            al1.Nombre = "Dani";
            al1.Apellidos = "Perez";
            al1.Dni = "4554654gh";
            Alumno al2 = new Alumno(al1.Guid,al1.Id,al1.Nombre,al1.Apellidos,al1.Dni);
            Assert.IsTrue(al1.Equals(al2));
        }
        
    }
}