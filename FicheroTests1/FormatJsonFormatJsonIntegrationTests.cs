using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fichero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Fichero.Tests
{

    [TestClass()]
    public class FormatJsonFormatJsonIntegrationTests
    {
        


        [DataRow(1, "dani", "madrigal", "efher748745")]
        [DataRow(2, "pepe", "perez", "ie233123")]
        //[DataRow(4, "jose", "garcia", "ksjf5465")]
        [TestMethod]
        public void AddAlumnoJsonTest(int id , string nombre , string apellido , string dni)
        {

            string path_test = "C:/Users/Daniel Madrigal/Downloads/Fichero/FicheroTests1/bin/Debug/Registro.json";
            string path = "Registro.json";
            Guid guid = Guid.NewGuid();
            Alumno al = new Alumno(guid,id, nombre, apellido, dni);
            FormatJson ft = new FormatJson();
            ft.AddAlumno(path, al);
            Assert.IsTrue(File.Exists(path_test));

            List<Alumno> alumnos = new List<Alumno>();
            Alumno registrado;
            using (FileStream fl = new FileStream(path_test,FileMode.Open,FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fl))
                {
                    string line = sr.ReadToEnd();
                    alumnos = JsonConvert.DeserializeObject<List<Alumno>>(line);
                }
                registrado = alumnos[0];
                registrado.Guid = guid;
            }
            Assert.IsTrue(al.Equals(registrado));
            File.Delete(path_test);
        }
     
    }
}