using System;

namespace ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, opcion;

            Console.WriteLine("Ingrese un numero:");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------");
            Console.WriteLine("Elige una de las siguientes opciones:");
            Console.WriteLine("1. Determinar si el numero es positivo o negativo");
            Console.WriteLine("2. Determinar si es par o impar");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    if (N >= 0)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("El numero que usted ingreso fue: " + N);
                        Console.WriteLine("Es Positivo");
                    }
                    else
                    {
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("El numero que usted ingreso fue: " + N);
                        Console.WriteLine("Es Negativo");
                    }
                    break;

                case 2:
                    int result;
                    result = N % 2;

                    if (result == 0)
                    {
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("El numero que usted ingreso fue: " + N);
                        Console.WriteLine("El numero es par");
                    }
                    else
                    {
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("El numero que usted ingreso fue: " + N);
                        Console.WriteLine("El numero es impar");
                    }
                    break;
                default:
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("No ingresaste niguna de las opciones");
                    break;
            }
            Console.ReadKey();
        }
    }
}
