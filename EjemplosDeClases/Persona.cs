using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosDeClases
{
    public class Persona
    {
        public string Dpi { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public string Genero { get; set; }
        public string Nacionalidad { get; set; }

        public int ObtenerEdad() {
            int edad = DateTime.Now.Year - FechaNacimiento.Year;
            return edad;
        }
    }
}
