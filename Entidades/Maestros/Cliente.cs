using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades.Maestros
{
    public class Cliente
    {
        #region Propiedades

        // Cabecera
        public string IdCliente { get; set; }
        public string IdEmpresa { get; set; }
        public string Nombre { get; set; }
        public string Mote { get; set; }
        public string NIF { get; set; }

        // Direccion Fiscal
        public string TipoVia { get; set; }
        public string Direccion { get; set; }
        public string NumDireccion { get; set; }
        public string CP { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }

        // Descuentos y Pagos
        public string RegimenIva { get; set; }
        public double Iva { get; set; }
        public string TipoIva { get; set; }
        public string FormaPago { get; set; }
        public string DocPago { get; set; }
        public string Moneda { get; set; }

        // Contactos
        public List<Contacto> Contactos { get; set; }

        // Otros
        public string precarga { get; set; }


        public Cliente()
        {
        }
        #endregion
    }
}
