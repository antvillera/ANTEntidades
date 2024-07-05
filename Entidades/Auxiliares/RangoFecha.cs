using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class RangoFecha
    {
        #region Propiedades
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        #endregion

        #region Constructor
        public RangoFecha(DateTime desde, DateTime hasta)
        {
            Desde = desde;
            Hasta = hasta;
        }
        #endregion

        #region Funciones
        public bool ComprendeFecha(DateTime fecha)
        {
            return fecha >= Desde && fecha <= Hasta;
        }
        #endregion
    }
}
