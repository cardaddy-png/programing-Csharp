using System;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;

            Console.WriteLine("Ingrese un numero: ");
            A = Convert.ToInt32(Console.ReadLine());

            if (A >= 0)
            {
                Console.WriteLine("El numero que usted ingreso fue: " + A);
                Console.WriteLine("Es Positivo");
            }
            else
            {
                Console.WriteLine("El numero que usted ingreso fue: " + A);
                Console.WriteLine("Es Negativo");
            }
            Console.ReadKey();
        }
    }
}
