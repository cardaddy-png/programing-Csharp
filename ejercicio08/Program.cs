using System;

namespace ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, E;
            int total;

            Console.WriteLine("Ingrese el primer valor : ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor : ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer valor : ");
            C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto valor : ");
            D = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el quinto valor : ");
            E = Convert.ToInt32(Console.ReadLine());

            total = A + B + C + D + E;
            double Rp = total / 5;

            Console.WriteLine("El promedio es de : " + Rp);
            Console.ReadKey();
        }
    }
}
