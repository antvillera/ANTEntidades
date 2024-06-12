using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class Pais
    {
        #region Constructor
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Comunitario { get; set; }
        #endregion

        #region Constructor
        public Pais(string codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }
        #endregion

        #region Funciones
        public override string ToString() => $"{Codigo} - {Nombre}";
        #endregion
    }
}
