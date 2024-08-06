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
        public string Nombre { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public bool Activa { get; set; }
        public List<Tarifa_Detalle> ProductosTarifa { get; set; }
        #endregion


        #region Constructor
        public Tarifa()
        {
            FechaDesde = new DateTime(DateTime.Now.Year, 1,1);
            FechaHasta = new DateTime(DateTime.Now.Year, 12, 31);
            ProductosTarifa = new List<Tarifa_Detalle>();
        }
        #endregion
    }
    
    public class Tarifa_Detalle
    {
        #region Propiedades
        public int IdDetalle { get; set; }
        public int IdTarifa { get; set; }
        public string IdVariedad { get; set; }
        public string IdConf { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }
        public bool Oculto { get; set; }
        #endregion
    }


}
