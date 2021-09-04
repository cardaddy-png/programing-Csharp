using System;

namespace ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 201; i <= 499; i += 2)
            {
                Console.WriteLine(" " + i);
                Console.WriteLine("-");
            }
            Console.ReadKey();
        }
    }
}
