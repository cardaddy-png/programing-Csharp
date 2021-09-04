using System;

namespace ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            Console.WriteLine("Opciones de menu:");
            Console.WriteLine("1. Pasa o no la materia?");
            Console.WriteLine("2. Es mayor o menor de edad ? ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    int A, B, C, D;

                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Ingrese la primera nota:");
                    A = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese la segunda nota: ");
                    B = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese la tercera nota: ");
                    C = Convert.ToInt32(Console.ReadLine());

                    D = (A + B + C) / 3;

                    if (D >= 30)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("El promedio del estudiante es de: " + D);
                        Console.WriteLine("El estudiante es aprovado");
                    }
                    else
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("El promedio del estudiante es de: " + D);
                        Console.WriteLine("El estudiante no fue aprovado");
                    }
                    break;
                case 2:

                    int E, F, G;

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Ingrese el año de nacimiento:");
                    E = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el año actual: ");
                    F = Convert.ToInt32(Console.ReadLine());

                    G = E - F;

                    if (G >= 18)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Tiene " + G + " Años");
                        Console.WriteLine("Es mayor de edad");
                    }
                    else
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Tiene " + G + " Años");
                        Console.WriteLine("Es menor de edad");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
