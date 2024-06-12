using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class TipoDocumento
    {
        #region Propiedades
        public string Id { get; set; }
        public string Nombre { get; set; }
        public bool Recomendado { get; set; }
        public bool Sistema { get; set; }
        #endregion

        #region Constructor
        public TipoDocumento(string id, string nombre, bool recomendado, bool sistema)
        {
            Id = id;
            Nombre = nombre;
            Recomendado = recomendado;
            Sistema = sistema;
        }
        #endregion
    }
}
