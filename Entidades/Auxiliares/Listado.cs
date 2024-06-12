using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class Listado
    {
        #region Propiedades
        public int Id { get; set; }
        public string Modulo { get; set; }
        public string Nombre { get; set; }
        public string ConsultaSQL { get; set; }
        public bool Obligatorio { get; set; }
        #endregion

        #region Constructor
        public Listado(int id = 0, string modulo = null, string nombre = null, string consultaSQL = null, bool obligatorio = false)
        {
            Id = id;
            Modulo = modulo;
            Nombre = nombre;
            ConsultaSQL = consultaSQL;
            Obligatorio = obligatorio;
        }
        #endregion
    }
}
