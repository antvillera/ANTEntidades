using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class ConfigLineasDoc
    {
        #region Propiedes
        public int IdConfig { get; set; }
        public string IdUsuario { get; set; }
        public string Formulario { get; set; }
        public string Campo { get; set; }
        public string Descripcion { get; set; }
        public bool Visible { get; set; }
        public bool Activo { get; set; }
        public bool Modificable { get; set; }
        public bool Sistema { get; set; }
        public int Orden { get; set; }
        #endregion

        #region Constructores
        public ConfigLineasDoc() { }
        public ConfigLineasDoc(int idConfig, string idUsuario, string formulario, string campo, string descripcion, bool visible, bool activo, bool modificable = true, bool sistema = false, int orden=0)
        {
            IdConfig = idConfig;
            IdUsuario = idUsuario;
            Formulario = formulario;
            Campo = campo;
            Descripcion = descripcion;
            Visible = visible;
            Activo = activo;
            Modificable = modificable;
            Sistema = sistema;
            Orden = orden;
        }
        #endregion
    }
}
