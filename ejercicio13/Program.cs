using System;

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            float A, B;

            Console.WriteLine("Ingrese un numero");
            A = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            B = float.Parse(Console.ReadLine());

            if (A > B)
            {
                Console.WriteLine("El numero mayor es " + A);
            }
            else if (A == B)
            {
                Console.WriteLine("Los numero son iguales " + A + " = " + B);
            }
            else
            {
                Console.WriteLine("El numero mayor es " + B);
            }
            Console.ReadKey();
        }
    }
}
