using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class Averia
    {
        #region Propiedades
        public string Empresa { get; set; }
        public string Centro { get; set; }
        public string Partida { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Variedad { get; set; }
        public string Confeccion { get; set; }
        public string Almacen { get; set; }
        public Tipo TipoAveria { get; set; }
        public int Cantidad { get; set; }
        public string Observaciones { get; set; }
        public enum Tipo
        {
            Alta = 'A',
            Baja = 'B',
            Merma = 'M',
            Devolucion = 'D',
            Intercentro = 'I',
            Transformacion = 'T'
        }
        #endregion

        #region Funciones
        public char CharTipoAveria() => (char)TipoAveria;
        #endregion
    }
}
