using System;

namespace ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            double X;
            double Z;

            Console.WriteLine("Ingrese el valor al que le va a calcular el 20% :");
            X = Convert.ToInt32(Console.ReadLine());
            Z = X * 0.2;
            Console.WriteLine("El 20% de : " + X + " es de : " + Z);
            Console.ReadKey();
        }
    }
}
