using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Motivo
    {
        #region Propiedades
        public int IdMotivo { get; set; }
        public string TipoMotivo { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        #endregion
    }
}
