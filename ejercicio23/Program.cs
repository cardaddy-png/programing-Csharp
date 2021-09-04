using System;

namespace ejercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int anno, peso, altura;

            Console.WriteLine("Ingrese el nombre del deportista:");
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese la edad:");
            anno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la altura o estatura:");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el peso:");
            peso = Convert.ToInt32(Console.ReadLine());

            if (anno <= 18)
            {
                if (altura >= 180)
                {
                    if (peso <= 80)
                    {
                        Console.WriteLine("Es aceptado");
                    }
                    else
                    {
                        Console.WriteLine("Es Rechazado");
                    }
                }
                else
                {
                    Console.WriteLine("Es Rechazado");
                }
            }
            else
            {
                Console.WriteLine("Es Rechazado");
            }
            Console.ReadKey();
        }
    }
}
