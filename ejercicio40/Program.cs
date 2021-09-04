using System;

namespace ejercicio40
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, count = 1, suma = 0;

            Console.WriteLine("Porfavor ingrese un numero natural o Limite ");
            n = Convert.ToInt32(Console.ReadLine());

            while (count < n)
            {
                suma = n * (n + 1) / 2;
                count++;
            }

            Console.WriteLine("El resultado de la suma de los numero naturales es de " + suma);
            Console.ReadKey();
        }
    }
}
