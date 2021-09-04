using System;

namespace ejercicio32
{
    class Program
    {
        static void Main(string[] args)
        {
            string X;
            int M, H, SUMA, suma;

            SUMA = 0;
            suma = 0;


            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine("Ingrese el sexo del la persona " + i);
                X = Convert.ToString(Console.ReadLine());
                Console.WriteLine("-----------------");


                if (X == "hombre")
                {
                    H = 1;
                    SUMA += H;
                }
                else
                {
                    M = 1;
                    suma += M;
                }
            }
            Console.WriteLine("Total de mujeres del grupo " + SUMA );
            Console.WriteLine("Total de hombres del grupo " + suma );
            Console.ReadKey();
        }
    }
}
