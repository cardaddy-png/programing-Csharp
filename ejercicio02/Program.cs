using System;

namespace ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int C;
            int resultado;

            Console.WriteLine("Ingrse el primer valor a multiplicar :");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor a multiplicar :");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer valor a multiplicar :");
            C = Convert.ToInt32(Console.ReadLine());
            resultado = A * B * C;
            Console.WriteLine("El resultado de la multiplicacion fue :" + resultado);
            Console.ReadKey();
        }
    }
}
