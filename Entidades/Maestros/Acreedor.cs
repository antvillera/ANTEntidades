using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class Acreedor
    {
        #region Propiedades
        public string id { get; set; }
        public string nombre { get; set; }
        public string poblacion { get; set; }
        public string provincia { get; set; }
        public string pais { get; set; }
        public string telefono { get; set; }
        #endregion

        #region Constructor
        public Acreedor(string id, string nombre, string poblacion = "", string provincia = "", string pais = "", string telefono = "")
        {
            this.id = id.Trim();
            this.nombre = nombre.Trim();
            this.poblacion = poblacion;
            this.provincia = provincia;
            this.pais = pais;
            this.telefono = telefono;
        }

        public Acreedor(DataRow row)
        {
            this.id = row["codigo"].ToString().Trim();
            this.nombre = row["nombre"].ToString().Trim();
            this.poblacion = row["poblacion"].ToString().Trim();
            this.provincia = row["provincia"].ToString().Trim();
            this.pais = row["pais"].ToString().Trim();
            this.telefono = row["telefono"].ToString().Trim();
        }
        #endregion

        #region Funciones
        public override string ToString() => $"{id} - {nombre}";
        #endregion
    }
}
