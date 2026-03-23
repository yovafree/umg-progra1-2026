using System;
using System.Collections.Generic;
using System.Text;

namespace ManejoArchivos2
{
    public class Estudiante
    {
        public string CodEstudiante { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Carrera { get; set; }

        public Estudiante() { 
        
        }
        public Estudiante(string codigo, string nombre, string edad, string carrera) {
            CodEstudiante = codigo;
            Nombre = nombre;
            Edad = edad;
            Carrera = carrera;
        }
    }
}
