using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class CuentaBancaria
    {
        #region Propiedades
        //****************************
        //          GENERAL
        //****************************
        
        public string iban_completo { get; set; }
        public string pais => iban_completo?.Substring(0,2) ?? "";
        public string iban => iban_completo?.Substring(0, 4) ?? "";
        public string banco => iban_completo?.Substring(4,4) ?? "";
        public string agencia => iban_completo?.Substring(8, 4) ?? "";
        public string digito => iban_completo?.Substring(12, 2) ?? "";
        public string cuenta => iban_completo?.Substring(14, 10) ?? "";
        public string bic { get; set; }

        public CuentaBancaria(string ibanCompleto, string bic = "") 
        {
            this.iban_completo = ibanCompleto;
            this.bic = bic;
        }
        #endregion
    }
}
