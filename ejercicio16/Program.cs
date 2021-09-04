using System;

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            int F, H, R;

            Console.WriteLine("a) Si los números son iguales restarlos");
            Console.WriteLine("b) Si los números son diferentes sumarlos");
            Console.WriteLine("Ingrese el primer numero:");
            F = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            H = Convert.ToInt32(Console.ReadLine());

            if (F == H)
            {
                R = F - H;
                Console.WriteLine("Los numeros que ingresaste fueron: " + F + " - " + H);
                Console.WriteLine("Resultado: " + R);
            }
            else
            {
                R = F + H;
                Console.WriteLine("Los numeros que ingresaste fueron: " + F + " + " + H);
                Console.WriteLine("Resultado: " + R);
            }
            Console.ReadKey();
        }
    }
}
