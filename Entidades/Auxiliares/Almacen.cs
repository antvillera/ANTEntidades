using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class Almacen
    {
        #region Propiedades
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Display => $"{Codigo}-{Nombre}";
        #endregion

        #region Constructor
        public Almacen(string codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }
        #endregion
    }
}
