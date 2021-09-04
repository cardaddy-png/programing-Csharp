using System;

namespace ejercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion, tiempo, velocidad, distancia;

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("1. Calcular distancia recorrida");
            Console.WriteLine("2. Calcular tiempo");
            Console.WriteLine("3. Calcular velocidad");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Elige una opcion ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese la velocidad:");
                    velocidad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el tiempo:");
                    tiempo = Convert.ToInt32(Console.ReadLine());
                    distancia = velocidad * tiempo;
                    Console.WriteLine("La distancia recorrida es de: " + distancia + " metros");
                    break;
                case 2:
                    Console.WriteLine("Ingrese la distancia:");
                    distancia = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese la velocidad:");
                    velocidad = Convert.ToInt32(Console.ReadLine());
                    tiempo = distancia / velocidad;
                    Console.WriteLine("El tiempo recorrido fue de : " + tiempo + " Segundos");
                    break;
                case 3:
                    Console.WriteLine("Ingrese la distancia:");
                    distancia = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el tiempo:");
                    tiempo = Convert.ToInt32(Console.ReadLine());
                    velocidad = distancia / tiempo;
                    Console.WriteLine("La velocidad recorrida es de: " + velocidad + " m/s");
                    break;
                default:
                    Console.WriteLine("No elegiste ninguna Opcion");
                    break;
            }
            Console.ReadKey();
        }
    }
}
