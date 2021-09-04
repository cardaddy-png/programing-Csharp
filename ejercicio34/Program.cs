using System;

namespace ejercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            int estatura, total, promedio = 0;


            for (int i = 1; i <= 18; i++)
            {
                Console.WriteLine("Ingrese la estatura del estudiante " + i );
                estatura = Convert.ToInt32(Console.ReadLine());

                promedio = promedio + estatura;
            }
            total = promedio / 18;
            Console.WriteLine("La estatura promedio del grupo es de  " + total);

            if (total <= 140)
            {
                Console.WriteLine("Estudiantes muy bajos");
            }
            else if (total <= 170)
            {
                Console.WriteLine("Estudiantes de estatura normal");
            }
            else
            {
                Console.WriteLine("Estudiantes muy altos");
            }
            Console.ReadKey();
        }
    }
}
