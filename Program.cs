using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA6TAREA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número máximo de personas:");
            int maxPersonas = int.Parse(Console.ReadLine());

            Console.Clear();

            int asistentesActuales = 0;
            int personasIngresaron = 0;
            int personasSalieron = 0;
            int vecesLleno = 0;
            int vecesVacio = 0;

            while (true)
            {
                double aforo = (double)asistentesActuales / maxPersonas * 100;

                Console.WriteLine("=================================");
                Console.WriteLine("| Asistentes actuales | " + asistentesActuales);
                Console.WriteLine("| Aforo | " + aforo.ToString("0") + "%");
                Console.WriteLine("| Máximo | " + maxPersonas + " personas");
                Console.WriteLine("=================================");

                Console.WriteLine("Presione");
                Console.WriteLine("[ i ] si ingresa una persona");
                Console.WriteLine("[ s ] si sale una persona");
                Console.WriteLine("[ x ] para terminar");

                char opcion = Console.ReadKey().KeyChar;

                Console.Clear();

                switch (opcion)
                {
                    case 'i':
                        if (asistentesActuales < maxPersonas)
                        {
                            asistentesActuales++;
                            personasIngresaron++;
                        }
                        else
                        {
                            Console.WriteLine("El local está lleno. No se pueden ingresar más personas.");
                            vecesLleno++;
                        }
                        break;
                    case 's':
                        if (asistentesActuales > 0)
                        {
                            asistentesActuales--;
                            personasSalieron++;
                        }
                        else
                        {
                            Console.WriteLine("El local ya está vacío. No se pueden sacar más personas.");
                            vecesVacio++;
                        }
                        break;
                    case 'x':
                        Console.Clear();
                        Console.WriteLine("======================== =========");
                        Console.WriteLine("El programa ha terminado");
                        Console.WriteLine("=================================");

                        Console.WriteLine("Estadísticas:");
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine(personasIngresaron + " personas ingresaron");
                        Console.WriteLine(personasSalieron + " personas salieron");
                        Console.WriteLine(vecesLleno + " veces se llenó el local");
                        Console.WriteLine("Estuvo vacío " + vecesVacio + " veces");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingrese 'i', 's' o 'x'.");
                        break;
                }
             } 
        }
    }
}