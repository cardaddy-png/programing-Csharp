using System;

namespace ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, V;

            Console.WriteLine("Ingrese un numero:");
            X = Convert.ToInt32(Console.ReadLine());

            V = X / 2;

            if (V >= 99)
            {
                Console.WriteLine("La mitad del numero es: " + V);
                Console.WriteLine("La mitad del numero es mayor de 100");
            }
            else
            {
                Console.WriteLine("La mitad del numero es: " + V);
                Console.WriteLine("La mitad del numero es menor de 100");
            }
            Console.ReadKey();
        }
    }
}
