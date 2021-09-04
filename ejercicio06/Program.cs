using System;

namespace ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            double Z;
            double A;
            double B;
            double C;

            Console.WriteLine("Ingrese el valor :");
            Z = Convert.ToInt32(Console.ReadLine());
            A = Z * 0.3;
            B = Z * 0.6;
            C = Z * 0.9;
            Console.WriteLine("El 30% de " + Z + " es de " + A);
            Console.WriteLine("El 60% de " + Z + " es de " + B);
            Console.WriteLine("El 90% de " + Z + " es de " + C);
            Console.ReadKey();
        }
    }
}
