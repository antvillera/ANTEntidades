using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    /// <summary>
    /// Entidad Contacto
    /// </summary>
    public class Contacto
    {
        #region Propiedades
        public string IdEmpresa { get; set; }
        public string IdProveedor { get; set; }
        public string TipoContacto { get; set; }
        public string IdContacto { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NIF { get; set; }
        public string Telefono { get; set; }
        public bool Defecto { get; set; }
        public bool Gerente { get; set; }
        public override string ToString()
        {
            return $"{Nombre} - {Apellidos}";
        }
        #endregion
    }
}
