using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{

    public class Tarifa
    {
        #region Propiedades
        public int IdTarifa { get; set; }
        public string IdProveedor { get; set; }
        public string IdVariedad { get; set; }
        public string IdConf { get; set; }
        public string Precio { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        #endregion


        #region Constructor
        public Tarifa()
        {
            FechaDesde = DateTime.Now;
            FechaHasta = DateTime.Now;
        }
        #endregion

    }
}
