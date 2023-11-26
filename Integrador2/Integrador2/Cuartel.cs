using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *Del cuartel, podemos realizar varias operaciones en particular:
1) Listar el estado de todos los operadores.
2) Listar el estado de todos los operadores que estén en cierta localización.
3) Hacer un total recall (llamado y retorno) general a todos los operadores.
4) Seleccionar un operador en específico y:
a) Enviarlo a una localización en especial.
b) indicar retorno a cuartel
c) cambiar estado a STANDBY - una entidad en STANDBY no puede ser
utilizada por comandos generales.
5) Agregar o remover operadores de la reserva.
 */

namespace Integrador2
{
 

    public class Cuartel
    {
        private List<Operador> operadores;

        // Constructor
        public Cuartel()
        {
            operadores = new List<Operador>();
        }

        // Método para agregar operadores al cuartel
        public void AgregarOperador(Operador operador)
        {
            operadores.Add(operador);
        }

        // Método para eliminar operadores del cuartel
        public void EliminarOperador(Operador operador)
        {
            operadores.Remove(operador);
        }

        // Método para obtener el estado de todos los operadores
        public List<string> ObtenerEstadoOperadores()
        {
            List<string> estados = new List<string>();
            foreach (var operador in operadores)
            {
                estados.Add($"{operador.ID}: {operador.EstadoGeneral}");
            }
            return estados;
        }

        // Método para enviar operadores a una nueva ubicación
        public void EnviarOperadores(string ubicacion)
        {
            foreach (var operador in operadores)
            {
                operador.Moverse(ubicacion);
            }
        }

        // Otros métodos como listar operadores por ubicación, cambiar estados, etc.

    }

}
