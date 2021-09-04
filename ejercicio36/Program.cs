using System;

namespace ejercicio36
{
    class Program
    {
        static void Main(string[] args)
        {
            int P;
            int N = 0;

            Console.WriteLine("Ingresa un numero al cual quiere multiplicar");
            P = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                N = P * i;
                Console.WriteLine("Resultado de " + P + " x " + i + " es " + N);
            }
            Console.ReadKey();
        }
    }
}
