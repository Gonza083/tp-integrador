using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2
{
    public class Operador
    {
        public string ID { get; set; }
        public Bateria Bateria { get; protected set; }
        public string EstadoGeneral { get; set; }
        public double CapacidadCargaMaxima { get; protected set; }
        public double VelocidadOptima { get; protected set; }
        public string UbicacionActual { get; set; }
        
        private double VelocidadInicial;

        public Operador(string id, Bateria bateria, double capacidadCargaMaxima, double velocidadOptima, string ubicacionActual)
        {
            ID = id; //haer funcin para generar id
            Bateria = bateria; //ver si esta relacionado bien con la calse bateria
            CapacidadCargaMaxima = capacidadCargaMaxima;
            VelocidadOptima = velocidadOptima;
            VelocidadInicial = velocidadOptima; //puesta una de ejemplo
            UbicacionActual = ubicacionActual;
        }

        public void Moverse(string nuevaUbicacion)
        {
            // Asumiendo que el movimiento consume batería
            Bateria.Consumir(10); // Ejemplo
            UbicacionActual = nuevaUbicacion;
            AjustarVelocidad();
            //ajustar esta funcion con la calse localizacion y consumo de bateria
        }

        protected void AjustarVelocidad()
        {
            double porcentajeBateria = Bateria.PorcentajeCarga();
            VelocidadOptima = VelocidadInicial * (1 - 0.05 * (100 - porcentajeBateria) / 10);
        }



        //metodos para agregar
        //transferir carga fisica
        //volver al cuartel y transferir carga fisica
        //volver al cuartel y cargar bateria

    }
}
