using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class Variedad
    {
        public string id;
        public string descripcion;
        public string tipo_iva;
        public List<Confeccion> confecciones;
        public object panel;

        public Variedad(string id, string descripcion, string tipo_iva)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.tipo_iva = tipo_iva;
            this.confecciones = new List<Confeccion>();
        }

        public Variedad(DataRow row) 
        {
            this.id = row["codVar"].ToString().Trim();
            this.descripcion = row["variedad"].ToString().Trim();
            this.confecciones = new List<Confeccion>();
        }

        public Variedad()
        {
        }

        public Confeccion GetConfeccion(string id)
        {
            return confecciones.FirstOrDefault(x => x.IdConf == id);
        }
    }
}
