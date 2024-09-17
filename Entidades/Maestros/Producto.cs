using ANTCommon.Conversions;
using ANTCommon.Messages;
using ANTEntidades.Maestros;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class ProductoLineasDto
    {
        #region Propiedades
        public int Empresa { get; set; }
        public string Variedad { get; set; }
        public string NombreVariedad { get; set; }
        public string Confeccion { get; set; }
        public string NombreConfeccion { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Tara { get; set; }
        public string Pais { get; set; }
        public bool PesoFijo { get; set; }
        public string Peso { get; set; }
        public double PrecioRef { get; set; }
        public double PrecioFijo { get; set; }
        public double PrecioMin { get; set; }
        public double BultosxPalet { get; set; }
        public double Stock { get; set; }
        public string Remitente { get; set; }
        public string Busqueda { get; set; }
        public string Vendedor { get; set; }
        public string Envase { get; set; }
        public string Calibre { get; set; }
        public string Categoria { get; set; }
        #endregion

        #region Constructor
        public ProductoLineasDto(DataRow row)
        {
            Empresa = Conversions.ToInt(row["empresa"].ToString());
            Variedad = row["codvar"].ToString().Trim();
            NombreVariedad = row["variedad"].ToString().Trim();
            Confeccion = row["codconf"].ToString().Trim();
            NombreConfeccion = row["confeccion"].ToString().Trim();
            Codigo = $"{row["codigo"].ToString().Trim()}";
            Descripcion = $"{row["variedad"].ToString().Trim()} {row["confeccion"].ToString().Trim()}";
            Tara = row["tara"].ToString().Trim();
            Pais = row["pais"].ToString().Trim();
            PesoFijo = row["peso_fijo"].ToString().Trim() == "S";
            Peso = string.IsNullOrEmpty(row["peso"].ToString().Trim()) ? "0" : row["peso"].ToString().Trim();
            PrecioFijo = Conversions.ToDouble(row["precio_fijo"]?.ToString().Trim());
            PrecioRef = Conversions.ToDouble(row["precio_ref"].ToString().Trim());
            PrecioMin = Conversions.ToDouble(row["precio_min"].ToString().Trim());
            Stock = Conversions.ToDouble(row["stock"].ToString().Trim());
            BultosxPalet = Conversions.ToDouble(row["bultosxpalet"].ToString());
            Remitente = row["ult_remitente"].ToString().Trim();
            Busqueda = row["busqueda"].ToString().Trim();
            Vendedor = row["vendedor"].ToString().Trim();
            Envase = row["envase"].ToString().Trim();
            Calibre = row["calibre"].ToString().Trim();
            Categoria = row["categoria"].ToString().Trim();
        }
        #endregion
    }

    public class Producto 
    {

        #region Propiedades
        public string IdEmpresa { get; set; }
        public string IdProducto { get; set; }
        public string Descripcion { get; set; }
        public string IdProveedor { get; set; }
        public string IdConfeccion { get; set; }
        public double Peso { get; set; }
        public bool PesoFijo { get; set; }
        public double Tara { get; set; }
        public string Envase { get; set; }
        public double BultosxPalet { get; set; }
        public double PlasticoNR { get; set; }
        public double PlasticoRE { get; set; }
        public bool Ecologico { get; set; }
        public double Volumen { get; set; }
        public string Categoria { get; set; }
        public string Calibre { get; set; }
        public string Marca { get; set; }
        public double Stock { get; set; }
        public double PrecioVenta { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioCoste { get; set; }
        public double PrecioMinimo { get; set; }
        public double PrecioReferencia { get; set; }
        public string Observaciones { get; set; }
        public string CuentaVenta { get; set; }
        public string CuentaCompra { get; set; }
        public string Moneda { get; set; }
        public string MonedaCompra { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }
        public string TipoIva { get; set; }
        public string TipoIvaCompras { get; set; }
        public string FamiliaEst { get; set; }
        public string TipoUnidad { get; set; }
        public string IdVariedad { get; set; }
        public string NombreVariedad { get; set; }

        public string NombreConfeccion { get; set; }
        public string Pais { get; set; }
        public string Vendedor { get; set; }

        public string Codigo => $"{IdVariedad.Trim()}-{IdConfeccion.Trim()}";
        #endregion

        public Producto()
        {
            IdEmpresa = "1";
        }

        public Producto(string idvariedad, string idconfeccion, string proveedor, string descripcion)
        {
            IdProducto = $"{idvariedad.Trim()}-{idconfeccion.Trim()}";
            IdVariedad = idvariedad;
            IdConfeccion = idconfeccion;
            IdProveedor = proveedor;
            Descripcion = descripcion.Trim().TrimEnd('-');
        }

        public override string ToString() => $"{IdProducto} - {Descripcion}";
    }
}
