using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2
{
    //unidades cuadrúpedas
    public class K9 : Operador
    {
        public K9(string id, string ubicacionActual)
            : base(id, new Bateria(6500), 40, 45, ubicacionActual) // 45 es un ejemplo de velocidad óptima
        {
        }
    }
}