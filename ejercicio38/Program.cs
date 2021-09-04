using System;

namespace ejercicio38
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota, total, promedio = 0;

            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Ingrese la nota numero " + i);
                nota = Convert.ToInt32(Console.ReadLine());

                promedio = promedio + nota;
            }
            total = promedio / 15;
            Console.WriteLine("la nota definitiva del estudiante es de " + total);

            if (total >= 40)
            {
                Console.WriteLine("El estduaintes paso(Gano) la materia ");
            }
            else
            {
                Console.WriteLine("El estduaintes no paso(perdio) la materia ");
            }
            Console.ReadKey();
        }
    }
}
