using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class Entidad
    {
        #region Propiedades
        public string Id { get; set; }
        public string Aplicacion { get; set; }
        public string Nombre { get; set; }
        public TipoDocumento Documentos { get; set; }

        public enum EntidadFacturacion
        {
            Prevision,
            Entrada
        }
        #endregion

        #region Constructor
        public Entidad(string id, string aplicacion, string nombre, TipoDocumento documentos = null)
        {
            Id = id;
            Nombre = nombre;
            Aplicacion = aplicacion;
            Documentos = documentos;
        }
        #endregion
    }
}
