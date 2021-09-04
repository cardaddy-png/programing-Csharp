using System;

namespace ejercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, X, N = 0;


            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Ingrese la edad del estudiante " + i);
                edad = Convert.ToInt32(Console.ReadLine());

                if (edad >= 18)
                {
                    X = 1;
                    N += X;
                }
                else
                {

                }
            }
            Console.WriteLine("El total de estudiantes mayores de edad es de " + N);
            Console.ReadKey();
        }
    }
}
