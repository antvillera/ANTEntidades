using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class Corredor
    {
        #region Propiedades
        public string id { get; set; }
        public string nombre { get; set; }
        #endregion

        #region Constructores
        public Corredor(string id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        #endregion

        #region Funciones
        public override string ToString() => $"{id} - {nombre}";
        #endregion
    }
}
