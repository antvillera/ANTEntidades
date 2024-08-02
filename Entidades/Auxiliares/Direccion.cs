using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades.Entidades.Auxiliares
{
    public class Direccion
    {
        public string TipoVia { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string CP { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }

        public Direccion() 
        {
            
        }
    }
}
