using System;

namespace ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            int K, L;

            Console.WriteLine("Ingrese un numero: ");
            K = Convert.ToInt32(Console.ReadLine());

            L = K % 2;

            if (L == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
            Console.ReadKey();
        }
    }
}
