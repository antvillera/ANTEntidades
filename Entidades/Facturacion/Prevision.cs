﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class Prevision
    {
        #region Propiedades
        public string Empresa { get; set; }
        public string Centro { get; set; }
        public string NumPrevision { get; set; }
        public DateTime Fecha { get; set; }
        public Proveedor Proveedor { get; set; }
        public List<LineaPrevision> Lineas { get; set; }
        public string Observaciones { get; set; }
        public bool Historico { get; set; }
        public string Usuario { get; set; }
        #endregion

        #region Constructor
        public Prevision(string empresa, string centro, string numPrevision, DateTime fecha, Proveedor proveedor, string observaciones, bool historico, string usuario)
        {
            Empresa = empresa;
            Centro = centro;
            NumPrevision = numPrevision;
            Fecha = fecha;
            Proveedor = proveedor;
            Observaciones = observaciones;
            Historico = historico;
            Lineas = new List<LineaPrevision>();
            Usuario = usuario;
        }
        #endregion
    }

    public class LineaPrevision
    {
        #region Propiedades
        public string Empresa { get; set; }
        public string Centro { get; set; }
        public DateTime Fecha { get; set; }
        public Proveedor Proveedor { get; set; }
        public int Posicion { get; set; }
        public Variedad VariedadLin { get; set; }
        public Confeccion ConfeccionLin { get; set; }
        public string Almacen { get; set; }
        public int Bultos { get; set; }
        public double BultosxPalet { get; set; }
        public double Bruto { get; set; }
        public double Tara { get; set; }
        public double Neto { get; set; }
        public double Precio { get; set; }
        public double Importe { get; set; }
        public string Pais { get; set; }
        public double Palet { get; set; }
        public int RowId { get; set; }
        public string NumPrevision { get; set; }
        public bool Historico { get; set; }
        #endregion
    }
}