using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class LineaFactura
    {
        public int numDoc;
        public string idArticulo;
        public string nombreArticulo;
        public int bultos;
        public string tipoIva;
        public double precio;
        public double bruto;
        public double tara;
        public bool pesoFijo;
        public List<string> lotes = new List<string>();
        public List<int> bultosLotes = new List<int>();

        public LineaFactura(int numDoc, string idArticulo, string nombreArticulo, int bultos, string tipoIva, double precio, double bruto, double tara, bool pesoFijo)
        {
            this.numDoc = numDoc;
            this.idArticulo = idArticulo;
            this.nombreArticulo = nombreArticulo;
            this.bultos = bultos;
            this.tipoIva = tipoIva;
            this.precio = precio;
            this.bruto = bruto;
            this.tara = tara;
            this.pesoFijo = pesoFijo;
        }

        public void SetLotes(string[] lotes, int[] bultosLotes)
        {
            this.lotes.Clear();
            this.bultosLotes.Clear();
            this.lotes.AddRange(lotes);
            this.bultosLotes.AddRange(bultosLotes);
        }
    }
}
