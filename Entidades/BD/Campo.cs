using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class Campo
    {
        public string Tabla { get; set; }
        public string Nombre { get; set; }

        public Campo(string tabla, string nombre)
        {
            Tabla = tabla;
            Nombre = nombre;
        }
    }
}
