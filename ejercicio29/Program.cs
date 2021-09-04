using System;

namespace ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for ( i = 0; i <= 200; i += 2)
            {
                Console.WriteLine(" " + i);
                Console.WriteLine("-");
            }
            Console.ReadKey();
        }
    }
}
