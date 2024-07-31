using ANTEntidades.Entidades.Auxiliares;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades.Maestros
{
    public class Cliente
    {
        #region Propiedades
        //****************************
        //          GENERAL
        //****************************
        // Cabecera
        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }
        public string Mote { get; set; }
        public string NIF { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Activo { get; set; }

        // Direcciones
        public Direccion DireccionFiscal { get; set; }
        public Direccion DireccionComercial { get; set; }
        public Direccion DireccionEnvio { get; set; }

        //****************************
        //          FACTURACION
        //****************************
        public string FormaPago { get; set; }
        public string DocPago { get; set; }
        public string Moneda { get; set; }
        public string Iban { get; set; }
        public int PlazoMaxPago { get; set; } // Dias que puede estar una factura sin pagar
        public string FormaFacturacion { get; set; } // Si se le pueden hacer (F) Facturas, (A) Albaranes o (T) ambos a documentos nuevos

        // Descuentos y Pagos
        public string RegimenIva { get; set; }
        public double Iva { get; set; }
        public string TipoIva { get; set; }

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
