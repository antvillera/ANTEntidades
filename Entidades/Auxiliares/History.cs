using ANTCommon.Conversions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades
{
    public class History
    {
        #region Propiedades
        public int HistoryId { get; set; }
        public string AppName { get; set; }
        public string Section { get; set; }
        public string FormName { get; set; }
        public string Action { get; set; }
        public string User { get; set; }
        public string Register { get; set; }
        public string ContractId { get; set; }
        public string SupplierId { get; set; }
        public DateTime DateProcess { get; set; }
        #endregion

        #region Constructor
        public History() { }

        public History(DataRow row)
        {
            HistoryId = int.Parse(row["codigo"].ToString().Trim());
            AppName = row["aplicacion"].ToString().Trim();
            Section = row["seccion"].ToString().Trim();
            User = row["codigo_usu"].ToString();
            Action = row["accion"].ToString();
            Register = row["registro"].ToString();
            FormName = row["formulario"].ToString();
            ContractId = row["idcontrato"].ToString();
            SupplierId = row["codigo_rem"].ToString();
            DateProcess = Conversions.ToDateTime(row["f_procesado"].ToString().Trim());
        }
        #endregion
    }
}
