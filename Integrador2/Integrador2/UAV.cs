using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2
{

    //drones voladores
    public class UAV : Operador
    {
        public UAV(string id, string ubicacionActual)
            : base(id, new Bateria(4000), 5, 60, ubicacionActual) // 60 es un ejemplo de velocidad óptima
        {
        }

        // Métodos y propiedades específicas de UAV
    }
}
