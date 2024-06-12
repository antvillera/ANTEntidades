using ANTEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class Entrada
    {
        #region Propiedades
        public string Empresa { get; set; }
        public string Centro { get; set; }

        [Display(Name = "Entrada")]
        public string NumEntrada { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaDoc { get; set; }
        public Proveedor Proveedor { get; set; }
        public string NumOriginal { get; set; }
        public string NumDocumento { get; set; }
        public string NumAlbaran { get; set; }
        public List<LineaEntrada> Lineas { get; set; }
        public string Observaciones { get; set; }
        public bool Historico { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
        public string IdTipoLiquidacion { get; set; }
        public Comprador Comprador { get; set; }
        #endregion

        #region Constructor
        public Entrada(string empresa, string centro, string numEntrada, DateTime fecha, DateTime fechaDoc, Proveedor proveedor, string numDocumento, string numOriginal, string numAlbaran, string observaciones, string estado, bool historico, string usuario, Comprador comprador, string idtipoliquidacion)
        {
            Empresa = empresa;
            Centro = centro;
            NumEntrada = numEntrada;
            Fecha = fecha;
            FechaDoc = fechaDoc;
            Proveedor = proveedor;
            NumOriginal = numOriginal.Replace("'", "");
            NumDocumento = numDocumento.Replace("'", "");
            NumAlbaran = numAlbaran.Replace("'", "");
            Observaciones = observaciones.Replace("'", "");
            Estado = estado;
            Historico = historico;
            Comprador = comprador;
            Usuario = usuario;
            IdTipoLiquidacion = idtipoliquidacion;
            Lineas = new List<LineaEntrada>();
        }

        public Entrada()
        {
        }
        #endregion
    }

    public class LineaEntrada
    {
        #region Propiedades
        public string Empresa { get; set; }
        public string Centro { get; set; }
        public string NumEntrada { get; set; }
        public int Posicion { get; set; }
        public Variedad VariedadLin { get; set; }
        public Confeccion ConfeccionLin { get; set; }
        public string Almacen { get; set; }
        public int Bultos { get; set; }
        public double BultosxPalet { get; set; }
        public double Tara { get; set; }
        public double Bruto { get; set; }
        public double Neto { get; set; }
        public double Precio { get; set; }
        public double Importe { get; set; }
        public double Palet { get; set; }
        public string Pais { get; set; }
        public string Peso { get; set; }
        public bool PesoFijo { get; set; }
        public string Medida { get; set; }
        public int RowIdPrevision { get; set; }
        #endregion

        #region Constructor
        public LineaEntrada()
        {
            RowIdPrevision = 0;
        }

        public LineaEntrada(string empresa, string centro, string numEntrada, Variedad variedad, Confeccion confeccion, double precio)
        {
            Empresa = empresa;
            Centro = centro;
            NumEntrada = numEntrada;
            VariedadLin = variedad;
            ConfeccionLin = confeccion;
            Precio = precio;
        }
        #endregion
    }
}
