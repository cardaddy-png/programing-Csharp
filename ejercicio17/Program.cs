using System;

namespace ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            int code, A, B, C, total;
            string nombre;
            string materia;

            Console.WriteLine("Ingresa el codigo del estudiante:");
            code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el nombre del estudiante:");
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre de la materia:");
            materia = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese la primera nota (10 a 50) del estudiante:");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota (10 a 50) del estudiante:");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota (10 a 50) del estudiante:");
            C = Convert.ToInt32(Console.ReadLine());

            total = (A + B + C) / 3;

            if (total >= 30)
            {
                Console.WriteLine("Codigo: " + code);
                Console.WriteLine("Nombre Estudiante: " + nombre);
                Console.WriteLine("Materia: " + materia);
                Console.WriteLine("Notas " + A + ", " + B + ", " + C + ".");
                Console.WriteLine("El estudiante aprovo con una nota de: " + total);
            }
            else
            {
                Console.WriteLine("Codigo: " + code);
                Console.WriteLine("Nombre Estudiante: " + nombre);
                Console.WriteLine("Materia: " + materia);
                Console.WriteLine("Notas " + A + ", " + B + ", " + C + ".");
                Console.WriteLine("El estudiante no aprovo, su promedio fue de: " + total);
            }
            Console.ReadKey();
        }
    }
}
