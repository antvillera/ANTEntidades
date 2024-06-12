using ANTCommon.Conversions;
using ANTCommon.Utils;
using ANTEntidades;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class TipoGasto
    {
        #region Propiedades
        public string IdTipoGasto { get; set; }
        public string Descripcion { get; set; }
        public string Destino { get; set; }
        public string Unidad { get; set; }
        public double Precio { get; set; }
        #endregion

        #region Constructor
        public TipoGasto()
        {

        }

        public TipoGasto(string idTipo, string descripcion)
        {
            IdTipoGasto = idTipo;
            Descripcion = descripcion;
        }

        public TipoGasto(DataRow row)
        {
            IdTipoGasto = row["Tipo"].ToString().Trim();
            Descripcion = row["Descripcion"].ToString().Trim();
            Destino = row["Destino"].ToString();
            Unidad = row["Unidad"].ToString().Trim();
            Precio = Conversions.ToDouble(row["Precio"].ToString());
        }
        #endregion

        #region Funciones
        public override string ToString() => $"{IdTipoGasto} - {Descripcion}";
        #endregion
    }

    public class Gasto
    {
        #region Propiedades
        public int Empresa { get; set; }
        public string Centro { get; set; }
        public string Tipo { get; set; }
        public int Posicion { get; set; }
        public string Unidad { get; set; }
        public string Partida { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public double Precio { get; set; }
        public double Importe { get; set; }
        public Acreedor acreedor { get; set; }
        public Proveedor proveedor { get; set; }
        public string Documento { get; set; }
        public List<Fichero> FicherosGastos { get; set; }
        #endregion

        #region Constructor
        public Gasto() { }

        public Gasto(DataRow row, DataTable dtFicheros)
        {
            Empresa = Conversions.ToInt(row["Empresa"].ToString().Trim());
            Centro = row["Centro"].ToString().Trim();
            Posicion = Conversions.ToInt(row["Posicion"].ToString().Trim());
            Tipo = row["Tipo"].ToString().Trim();
            Partida = row["Partida"].ToString().Trim();
            Unidad = row["Unidad"].ToString().Trim();
            Descripcion = row["Descripcion"].ToString().Trim();
            Cantidad = Conversions.ToDouble(row["Cantidad"].ToString().Trim());
            Precio = Conversions.ToDouble(row["Precio"].ToString().Trim());
            Importe = Conversions.ToDouble(row["Importe"].ToString().Trim());
            acreedor = new Acreedor(row["IdAcreedor"].ToString().Trim(), row["NombreAcreedor"].ToString().Trim());
            Documento = row["Documento"].ToString().Trim();

            FicherosGastos = dtFicheros.AsEnumerable()
                                        .Where(rowFichero => rowFichero["posicion"].ToString() == Posicion.ToString())
                                        .Select(rowFichero => new Fichero()
                                        {
                                            IdFichero = Conversions.ToInt(rowFichero["codigo"].ToString()),
                                            Posicion = Conversions.ToInt(rowFichero["posicion"].ToString()),
                                            Ruta = rowFichero["ruta"].ToString().Trim()
                                        })
                                        .ToList();
        }
        #endregion
    }
}
