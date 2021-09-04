using System;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int year01;
            int year02;
            int anno;

            Console.WriteLine("Ingresa el año Actual: ");
            year01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el año de nacimiento: ");
            year02 = Convert.ToInt32(Console.ReadLine());

            anno = year01 - year02;

            if (anno >= 18)
            {
                Console.WriteLine("Su edad es: " + anno);
                Console.WriteLine("Es Usted mayor de edad");
            }
            else
            {
                Console.WriteLine("Su edad es: " + anno);
                Console.WriteLine("Es Usted menor de edad");
            }
            Console.ReadKey();
        }
    }
}
