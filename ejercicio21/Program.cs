using System;

namespace ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f, g, t;

            Console.WriteLine("Ingrese la tmperatura del lunes:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la tmperatura del Martes:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la tmperatura del Miercoles:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la tmperatura del Jueves:");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la tmperatura del Viernes:");
            e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la tmperatura del sabado:");
            f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la tmperatura del Domingo:");
            g = Convert.ToInt32(Console.ReadLine());

            t = (a + b + c + d + e + f + g) / 7;

            if (t >= 35)
            {
                Console.WriteLine("La temperatura de la semana fue de: " + t + "°");
                Console.WriteLine("Que semana tan calurosa");
            }
            else if (t <= 15)
            {
                Console.WriteLine("La temperatura de la semana fue de: " + t + "°");
                Console.WriteLine("Que semana tan fría");
            }
            else
            {
                Console.WriteLine("La temperatura de la semana fue de: " + t + "°");
                Console.WriteLine("Que clima tan delicioso");
            }
            Console.ReadKey();
        }
    }
}
