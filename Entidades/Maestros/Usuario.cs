using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class Usuario
    {
        #region Propiedades
        public string IdUsuario { get; set; }
        public string Nombre { get; set; }
        #endregion

        #region Constructor
        public Usuario(string idusuario, string nombre)
        {
            IdUsuario = idusuario;
            Nombre = nombre;
        }

        public Usuario(DataRow row)
        {
            IdUsuario = row["codigo"].ToString().Trim();
            Nombre = row["nombre"].ToString().Trim();
        }

        public override string ToString()=> $"{IdUsuario} - {Nombre}";
        #endregion
    }
}
