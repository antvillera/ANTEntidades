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
        public string idCliente { get; set; }
        public string nombre { get; set; }
        public string razonSocial { get; set; }
        public string mote { get; set; }
        public string nif { get; set; }
        public DateTime fechaAlta { get; set; }
        public bool obsoleto { get; set; }
        public bool bloqueado { get; set; }

        // Direcciones
        public Direccion direccionFiscal { get; set; }
        public Direccion direccionComercial { get; set; }
        public Direccion direccionEnvio { get; set; }

        //****************************
        //          FACTURACION
        //****************************
        public string formaPago { get; set; }
        public string docPago { get; set; }
        public string moneda { get; set; }
        public CuentaBancaria cuentaBancaria { get; set; }
        public string formaFacturacion { get; set; } // Si se le pueden hacer (F) Facturas, (A) Albaranes o (T) ambos a documentos nuevos
        public string tipoCliente { get; set; }     // Tipo de cliente: Mayorista o Detallista 

        public double rappel { get; set; }
        public double financiacion { get; set; }
        public bool tieneBloqueo { get; set; }
        public int plazoMaxPago { get; set; } // Dias que puede estar una factura sin pagar
        public int importeMaxPago { get; set; }
        ///-------------------------------------------
        public string regimenIva { get; set; } 
        public double iva { get; set; }             ///--- OCULTOS ---
        public string tipoIva { get; set; }

        //****************************
        //          CONTABILIDAD
        //****************************
        public string[] cuentas { get; set; }

        //****************************
        //          COMERCIAL
        //****************************
        public bool precargaVenta { get; set; }
        public bool paletizar { get; set; }
        public bool sinPagar { get; set; }

        //****************************
        //          CONTACTOS
        //****************************
        public List<Contacto> contactos { get; set; }

        //****************************
        //          AVISOS
        //****************************
        public bool avisoVenta { get; set; }
        public bool avisoFacturacion { get; set; }
        public string msgVenta { get; set; }
        public string msgFacturacion { get; set; }


        public Cliente(string idCliente)
        {
            this.idCliente = idCliente;
            this.direccionFiscal = new Direccion();
            this.direccionComercial = new Direccion();
            this.direccionEnvio = new Direccion();
            this.cuentas = new string[12];

            string[] prefijosCuentas = new string[12] { "4300", "4310", "4311", "4380", "4380", "4380", "4360", "4315", "7000", "7080", "4730", "4730" };
            for (int i = 0; i < 12; i++)
            {
                this.cuentas[i] = prefijosCuentas[i];
                this.cuentas[i] += i < 8 ? idCliente.PadLeft(8, '0') : "0".PadLeft(8, '0');   // Las 8 primeras son especificas de cliente y las 4 ultimas son genericas
            }
        }
        #endregion
    }
}
