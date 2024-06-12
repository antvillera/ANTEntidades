using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class TipoLiquidacion
    {
        #region Constantes
        public const string PRECIO = "P";
        public const string COMISION = "C";
        public const string COMISION_QUILOS = "Q";
        #endregion

        #region Propiedades
        public string Id { get; set; }
        public string Nombre { get; set; }
        #endregion

        #region Constructor
        public TipoLiquidacion(string id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
        #endregion
    }
}
