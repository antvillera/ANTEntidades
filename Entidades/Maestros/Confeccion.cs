using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ANTEntidades
{
    public class Confeccion
    {
        public string empresa;
        public Variedad variedad;
        public string IdConf;
        public string descripcion;
        public string pais;
        public double peso;
        public bool peso_fijo;
        public string Vendedor;
        public object panel;
        public double BultosxPalet { get; set; }
        public double Tara { get; set; }

        public double PrecioRef { get; set; }
        public double PrecioMin { get; set; }

        public Confeccion(string empresa, Variedad variedad, string id, string descripcion)
        {
            this.empresa = empresa;
            this.variedad = variedad;
            this.IdConf = id;
            this.descripcion = descripcion;
        }

        public Confeccion(string empresa, Variedad variedad, string id, string descripcion, bool peso_fijo, double peso, double precio_ref, double precio_min, string pais, string vendedor, double bultosxpalet, double tara)
        {
            this.empresa = empresa;
            this.variedad = variedad;
            this.IdConf = id;
            this.descripcion = descripcion;
            this.pais = pais;
            this.peso = peso;
            this.peso_fijo = peso_fijo;
            this.PrecioRef = precio_ref;
            this.PrecioMin = precio_min;
            Tara = tara;
            BultosxPalet = bultosxpalet;
            Vendedor = vendedor;
        }

        public Confeccion(Variedad variedad, DataRow row)
        {
            this.variedad = variedad;
            this.empresa = row["empresa"].ToString().Trim();
            this.IdConf = row["codconf"].ToString().Trim();
            this.descripcion = row["confeccion"].ToString().Trim();
        }

        public Confeccion()
        {
        }

        public override string ToString()
        {
            return $"{IdConf} - {descripcion}";
        }
    }
}
