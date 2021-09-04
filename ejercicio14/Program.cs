using System;

namespace ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int Grado;

            Console.WriteLine("Ingrese el grado del estudiante: ");
            Grado = Convert.ToInt32(Console.ReadLine());

            if (Grado <= 6)
            {
                Console.WriteLine("Grado " + Grado);
                Console.WriteLine("El grado requiere refrigerio");
            }
            else
            {
                Console.WriteLine("Grado " + Grado);
                Console.WriteLine("Por disposición de la Secretaria de Educación el curso no requiere refiguerio");
            }
            Console.ReadKey();
        }
    }
}
