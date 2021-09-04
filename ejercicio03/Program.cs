using System;

namespace ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            double vel;

            Console.WriteLine("Ingrese la velocidad en km/h: ");
            vel = Convert.ToDouble(Console.ReadLine());

            double A;
            A = 3.6;
            double conv;
            conv = vel / A;

            Console.WriteLine("Convertimos Km/h en m/s que es igual a: " + conv + " m/s");

            double tim;
            double dis;

            Console.WriteLine("Ingres el tiempo segundos:");
            tim = Convert.ToDouble(Console.ReadLine());
            dis = vel * tim;
            Console.WriteLine("La distancia recorrida fue de: " + dis + " metros");
            Console.ReadKey();
        }
    }
}
