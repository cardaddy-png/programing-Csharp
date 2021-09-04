using System;

namespace ejercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            Console.WriteLine("Programa que permita determinar si una letra es o no vocal");
            Console.WriteLine("Ingrese una letra: ");
            letra = Convert.ToChar(Console.ReadLine());

            switch (letra)
            {
                case 'a':
                    Console.WriteLine("La letra ingresada es la vocal A");
                    break;
                case 'e':
                    Console.WriteLine("La letra ingresada es la vocal E");
                    break;
                case 'i':
                    Console.WriteLine("La letra ingresada es la vocal I");
                    break;
                case 'o':
                    Console.WriteLine("La letra ingresada es la vocal O");
                    break;
                case 'u':
                    Console.WriteLine("La letra ingresada es la vocal U");
                    break;
                default:
                    Console.WriteLine("No es una vocal");
                    break;
            }
            Console.ReadKey();
        }
    }
}
