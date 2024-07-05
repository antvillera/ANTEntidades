using ANTCommon.Conversions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class PlantillaLinea
    {
        #region Propiedades
        public string Empresa { get; set; }
        public string Centro { get; set; }
        public string Proveedor { get; set; }
        public Variedad VariedadLin { get; set; }
        public Confeccion ConfeccionLin { get; set; }
        public int Posicion { get; set; }
        public double Precio { get; set; }
        #endregion

        #region Constructor
        public PlantillaLinea()
        {
                
        }
        public PlantillaLinea(DataRow row)
        {
            Empresa = row["empresa"].ToString().Trim();
            Centro = row["centro"].ToString().Trim();
            Proveedor = row["proveedor"].ToString().Trim();
            VariedadLin = new Variedad(row["variedad"].ToString().Trim(), row["descripcion"].ToString().Trim(),"");

            ConfeccionLin = new Confeccion(Empresa,
                VariedadLin,
                row["confeccion"].ToString().Trim(),
                row["complemento"].ToString().Trim(),
                row["peso_fijo"].ToString().Trim() == "S",
                Conversions.ToDouble(row["peso"].ToString()),
                Conversions.ToDouble(row["precio_ref"]),
                Conversions.ToDouble(row["precio_min"]),
                row["pais"].ToString().Trim(),
                row["vendedor"].ToString().Trim(),
                 Conversions.ToDouble(row["bultosxpalet"]),
                 Conversions.ToDouble(row["tara"]), Conversions.ToDouble(row["tara_compra"]));

            Posicion = Conversions.ToInt(row["posicion"].ToString());
            Precio = Conversions.ToDouble(row["precio"].ToString());
        }

        #endregion
    }
}
