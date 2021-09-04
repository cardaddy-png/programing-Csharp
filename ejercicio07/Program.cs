using System;

namespace ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado;
            int area;

            Console.WriteLine("Ingresa la medida de un lados del cuadrado : ");
            lado = Convert.ToInt32(Console.ReadLine());
            area = lado * lado;
            Console.WriteLine("El area del cuadrado es de : " + area);
            Console.ReadKey();
        }
    }
}
