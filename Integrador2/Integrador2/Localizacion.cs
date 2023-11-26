using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2
{
    public class Localizacion
    {
        public int X { get; set; }
        public int Y { get; set; }

        // Constructor
        public Localizacion(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Metodo para actualizar la ubicación
        public void Mover(int nuevoX, int nuevoY)
        {
            X = nuevoX;
            Y = nuevoY;
        }

        // Metodo opcional para calcular la distancia entre dos localizaciones
        public static double CalcularDistancia(Localizacion loc1, Localizacion loc2)
        {
            return Math.Sqrt(Math.Pow(loc2.X - loc1.X, 2) + Math.Pow(loc2.Y - loc1.Y, 2));
        }
        
        // Metodo para representar la localización como cadena de texto (opcional)
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

}
