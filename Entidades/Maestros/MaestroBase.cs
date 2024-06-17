using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTEntidades.Maestros
{
    public abstract class MaestroBase
    {
        public abstract bool Eliminar(string id);
        public abstract bool Buscar(string id);
        public abstract bool MapearObjeto(string id);
        public abstract bool GuardarEnBBDD();
    }
}
