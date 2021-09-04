using System;

namespace ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int edad;

            Console.WriteLine("Ingresa el año actual : ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el año de nacimiento : ");
            B = Convert.ToInt32(Console.ReadLine());
            edad = A - B;
            Console.WriteLine("Tu edad es de : " + edad + " Años");
            Console.ReadKey();
        }
    }
}
