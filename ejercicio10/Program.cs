using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int salario;
            int dias;
            int total;
            double pension, health, salary;

            Console.WriteLine("Salario diario: ");
            salario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dias trabajados:");
            dias = Convert.ToInt32(Console.ReadLine());

            total = salario * dias;
            pension = total * 0.10;
            health = total * 0.15;
            salary = total - pension - health;

            Console.WriteLine("Salario total:" + total);
            Console.WriteLine("Menos 10% de pension: " + pension);
            Console.WriteLine("Menos 15% de salud: " + health);
            Console.WriteLine("Total: " + salary);
            Console.ReadKey();
        }
    }
}
