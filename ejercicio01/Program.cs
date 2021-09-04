using System;

namespace ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int resultado;

            Console.WriteLine("Ingrese el primer valor que quiere sumar :");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor que quiere sumar :");
            B = Convert.ToInt32(Console.ReadLine());
            resultado = A + B;
            Console.WriteLine("Resultado de la suma : " + resultado);
            Console.ReadKey();
        }
    }
}
