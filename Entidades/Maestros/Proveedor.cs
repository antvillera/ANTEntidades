using ANTCommon.Conversions;
using ANTEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class Proveedor 
    {
        #region Propiedades
        public string empresa;
        public string id;
        public bool activo;
        public string nombre;
        public string nombreLargo;
        public string mote;
        public string poblacion;
        public string provincia;
        public string pais;
        public string nif;
        public string cp;
        public string telefono;
        public string cuenta;
        public DateTime fechaAlta;
        public string email;
        public string web;
        public string IdComprador;
        private Comprador comprador = null;
        public string IdCorredor;
        public string RemitenteStock;
        private Corredor corredor = null;
        #endregion

        #region Constructor
        public Proveedor()
        {

        }
        public Proveedor(string id, string nombre, string poblacion = "", string provincia = "", string pais = "", string telefono = "")
        {
            empresa = "1";
            this.id = id;
            this.nombre = nombre;
            this.poblacion = poblacion;
            this.provincia = provincia;
            this.pais = pais;
            this.telefono = telefono;
        }

        public Proveedor(DataRow row)
        {
            this.id = row["codigo"].ToString().Trim();
            this.nombre = row["nombre"].ToString().Trim();
            this.nombreLargo = row["lnombre"].ToString().Trim();
            this.poblacion = row["poblacion"].ToString().Trim();
            this.provincia = row["provincia"].ToString().Trim();
            this.pais = row["pais"].ToString().Trim();
            this.telefono = row["telefono"].ToString().Trim();
            this.email = row["email"].ToString().Trim();
            this.RemitenteStock = row["remitente_stock"].ToString().Trim();
        }
        #endregion

        #region Functions 
        public override string ToString()=> $"{id} - {nombre}";
    }
    #endregion
}
