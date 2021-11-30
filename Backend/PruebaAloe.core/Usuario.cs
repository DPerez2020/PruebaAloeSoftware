using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaAloe.core
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public char Genero { get; set; }
        public string Cedula { get; set; }
        public string Cargo { get; set; }
        public Usuario SupervisorInmediato { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Departamento Departamento { get; set; }
    }
}
