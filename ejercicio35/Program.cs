using System;

namespace ejercicio35
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 99; i += 3)
            {
                Console.WriteLine(" " + i);
                Console.WriteLine("-");
            }
            Console.ReadKey();
        }
    }
}
