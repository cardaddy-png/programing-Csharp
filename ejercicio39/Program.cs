using System;

namespace ejercicio39
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, total = 1, count = 0;

            Console.WriteLine("Ingrese el valor de la base");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del exponente");
            B = Convert.ToInt32(Console.ReadLine());

            while (count < B)
            {
                total = total * A;
                count++;
            }

            Console.WriteLine("El valor de la base es " + A);
            Console.WriteLine("potencia del exponente " + B);
            Console.WriteLine("El resultado es " + total);
            Console.ReadKey();
        }
    }
}
