using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Esta en el programa de Sky.net, precione una tecla para continuar");
            Console.ReadKey();
            int opcion;

            do {

                Console.WriteLine("\n1.Mostrar estados los operadores");
                Console.WriteLine("2.Listar estado por localizacion");//que te de la opcion de elegir localizacion
                Console.WriteLine("3.Recall");
                Console.WriteLine("4.Seleccionar operador");//este tiene que darte mas opciones
                Console.WriteLine("5.Agregar Operador");
                Console.WriteLine("6.Quitar Operador");

                Console.Write("\nElija una opción: ");


                opcion = int.Parse(Console.ReadLine());

                

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("mostrar estado");
                        break;
                    case 2:
                        Console.WriteLine("Listar el estado de todos los operadores que estén en cierta localización");
                        break;
                    case 3:
                        Console.WriteLine("Hacer un total recall (llamado y retorno) general a todos los operadores.");
                        break;
                    case 4:
                        Console.WriteLine("mostrar estado");
                        /*Seleccionar un operador en específico y:
    a) Enviarlo a una localización en especial.
    b) indicar retorno a cuartel
    c) cambiar estado a STANDBY - una entidad en STANDBY no puede ser
    utilizada por comandos generales.*/
                        break;
                    case 5:
                        Console.WriteLine("Agregar o remover operadores de la reserva.");
                        break;
                    case 6:
                        Console.WriteLine("agregar operador");
                        break;
                    default:
                        Console.Clear();
                        break;


                }

            } while (opcion >= 1 && opcion <= 6);

           
 
            
          /*  // Crear el cuartel
            Cuartel cuartel = new Cuartel();

            // Crear operadores
            Operador uav1 = new UAV("UAV001", "Base");
            Operador k91 = new K9("K9001", "Base");
            Operador m81 = new M8("M8001", "Base");

            // Agregar operadores al cuartel
            cuartel.AgregarOperador(uav1);
            cuartel.AgregarOperador(k91);
            cuartel.AgregarOperador(m81);

            // Realizar algunas acciones
            uav1.Moverse("Punto A");
            k91.Moverse("Punto B");
            m81.Moverse("Punto C");

            // Mostrar el estado de los operadores
            var estados = cuartel.ObtenerEstadoOperadores();
            foreach (var estado in estados)
            {
                Console.WriteLine(estado);
            }
          */
        }
    }
}
