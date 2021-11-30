using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaAloe.DTO
{
    public class UsuarioDTO
    {        
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Genero { get; set; }
        public string Cedula { get; set; }
        public string Cargo { get; set; }
        public string Supervisor { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Departamento { get; set; }
    }
}
