using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades.Entidades.Auxiliares
{
    public class Oferta
    {
        #region Propiedades
        public int IdOferta { get; set; }
        public string IdProveedor { get; set; }
        public string IdVariedad { get; set; }
        public string IdConfeccion { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public string Precio { get; set; }
        public bool Oculto { get; set; }

        #endregion
    }
}
