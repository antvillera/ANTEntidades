using ANTEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTraductor.Entidades
{
    internal class Contrato
    {
        #region Propiedades
        public int IdContrato { get; set; }
        public string IdEmpresa { get; set; }
        public string TipoContrato { get; set; }
        public Proveedor Proveedor { get; set; }
        public string Estado { get; set; }
        public string TipoEnvio { get; set; }
        public DateTime FechaContrato { get; set; }
        public DateTime FechaProcesado { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Documento { get; set; }
        public string Destinatario { get; set; }
        public bool SubidaAica { get; set; }
        public string SignatureId { get; set; }
        public string Resultado { get; set; }
        public string IdUsuario { get; set; }
        public string Centro { get; set; }
        public string NumeroDoc { get; set; }

        #endregion
    }
}
