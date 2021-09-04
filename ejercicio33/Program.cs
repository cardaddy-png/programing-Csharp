using System;

namespace ejercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, P = 0, total;

            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Ingrese la edad de la persona " + i);
                edad = Convert.ToInt32(Console.ReadLine());

                P = P + edad;
            }
            total = P / 15;
            Console.WriteLine("Promedio de edad en el grupo " + total);
            Console.ReadKey();
        }
    }
}
