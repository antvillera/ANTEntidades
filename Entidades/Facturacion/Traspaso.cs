using ANTCommon.Conversions;
using ANTEntidades.Maestros;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ANTEntidades.Entidades.Facturacion
{
    public class Traspaso
    {
        #region Propiedades
        public string IdTraspaso { get; set; }
        public string Serie { get; set; }
        public string NumTraspaso { get; set; }
        public DateTime Fecha { get; set; }
        public string AlmacenOrigen { get; set; }
        public string AlmacenDestino { get; set; }
        public string Motivo { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }

        public List<LineaTraspaso> Lineas { get; set; }
        #endregion

        #region Constructor
        public Traspaso()
        {
            Lineas = new List<LineaTraspaso>();
        }

        public Traspaso(string idTraspaso, string serie, string numTraspaso, string almacenOrigen, string almacenDestino, DateTime fecha, string motivo, string observaciones, string estado)
        {
            IdTraspaso = idTraspaso;
            Serie = serie;
            AlmacenOrigen = almacenOrigen.Trim();
            AlmacenDestino = almacenDestino.Trim();
            NumTraspaso = numTraspaso;
            Fecha = fecha;
            Motivo = motivo;
            Observaciones = observaciones;
            Estado = estado;
            Lineas = new List<LineaTraspaso>();
        }
        #endregion
    }

    public class LineaTraspaso
    {
        public string IdTraspaso { get; set; }
        public int Posicion { get; set; }
        public Variedad VariedadLin { get; set; }
        public Confeccion ConfeccionLin { get; set; }
        public int Bultos { get; set; }
        public bool PesoFijo { get; set; }
        public double Peso { get; set; }
        public double Tara { get; set; }
        public double Bruto { get; set; }
        public double Neto { get; set; }
        public double Palet { get; set; }
        public string AlmacenOrigen { get; set; }
        public string AlmacenDestino { get; set; }
        public double BultosxPalet { get; set; }
        public string Lote { get; set; }
        public string BultosLote { get; set; }

        #region Constructor

        public LineaTraspaso()
        {
                
        }
        public LineaTraspaso(DataRow rowLin)
        {
            Variedad variedad = new Variedad(rowLin["variedad"].ToString().Trim(), rowLin["descripcion_var"].ToString().Trim(), "");
            Confeccion confeccion = new Confeccion("",
                                                   variedad,
                                                   rowLin["confeccion"].ToString().Trim(),
                                                   rowLin["descripcion_conf"].ToString().Trim(),
                                                   rowLin["peso_fijo"].ToString().Trim() == "S",
                                                   Conversions.ToDouble(rowLin["peso"].ToString()),
                                                   0,
                                                   0,
                                                   "",
                                                   "",
                                                   Conversions.ToDouble(rowLin["bultosxpalet"]),
                                                   Conversions.ToDouble(rowLin["tara"]),
                                                   0);


            Posicion = Conversions.ToInt(rowLin["posicion"].ToString());
            VariedadLin = variedad;
            ConfeccionLin = confeccion;
            Bultos = Conversions.ToInt(rowLin["bultos"]);
            Tara = Conversions.ToDouble(rowLin["tara"]);
            Peso = Conversions.ToDouble(rowLin["peso"]);
            PesoFijo = rowLin["peso_fijo"].ToString().Trim() == "S";
            Bruto = Conversions.ToDouble(rowLin["bruto"]);
            Neto = Conversions.ToDouble(rowLin["neto"]);
            AlmacenOrigen = rowLin["origen"].ToString().Trim();
            AlmacenDestino = rowLin["destino"].ToString().Trim();
            BultosxPalet = Conversions.ToDouble(rowLin["bultosxpalet"]);
            Lote = rowLin["lote"].ToString().Trim();
            BultosLote = rowLin["bultoslote"].ToString().Trim();
        }
        #endregion
    }
}
