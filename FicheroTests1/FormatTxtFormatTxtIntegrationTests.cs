using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fichero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fichero.Tests
{
  
    [TestClass()]
    public class FormatTxtFormatTxtIntegrationTests
    {

        [DataRow(1, "dani", "madrigal", "efher748745")]
        [DataRow( 2, "pepe", "perez", "ie233123")]
        [DataRow(4, "jose", "garcia", "ksjf5465")]
        [TestMethod]
        public void AddAlumnoTxtTest(int id, string nombre, string apellido, string dni)
        {
            string path = "C:/Users/Daniel Madrigal/Downloads/Fichero/FicheroTests1/bin/Debug/Registro.txt";
            Guid guid = Guid.NewGuid();
            Alumno al = new Alumno(guid,id, nombre, apellido, dni);
            FormatTxt ft = new FormatTxt("txt");
            ft.Add(al);
            Assert.IsTrue(File.Exists(path));


            Alumno registrado;
            List<Alumno> Alumnos = new List<Alumno>();
            bool Encontrado = false;
            using (FileStream fl = new FileStream(path,FileMode.Open,FileAccess.Read))
            {
                using (StreamReader sw= new StreamReader(fl))
                {
                    string line;
                    while ( (line = sw.ReadLine())!=null)
                    {
                        string[] lines = line.Split(',');
                        registrado = new Alumno(guid,Convert.ToInt32(lines[0]), lines[1], lines[2], lines[3]);
                        Alumnos.Add(registrado);
                    }


                }
            }
            
            foreach (var i in Alumnos)
            {
                if (al.Equals(i)) Encontrado = true;
            }
            Assert.IsTrue(Encontrado);
        }

       
    }
}