using System;

namespace ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad, precio, X;
            double descuento, total;

            Console.WriteLine("Ingrese la cantidad de articulos que va comprar:");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor unitario del producto:");
            precio = Convert.ToInt32(Console.ReadLine());

            X = cantidad * precio;

            if (X >= 20000)
            {
                descuento = X * 0.35;
                total = X - descuento;
                Console.WriteLine("Cantidad de productos: " + cantidad);
                Console.WriteLine("Valor unitario: " + precio);
                Console.WriteLine("El valor de su compra es de: " + X);
                Console.WriteLine("Descuento 35% : " + descuento);
                Console.WriteLine("Total a pagar: " + total);
            }
            else
            {
                descuento = X * 0.15;
                total = X - descuento;
                Console.WriteLine("Cantidad de productos: " + cantidad);
                Console.WriteLine("Valor unitario: " + precio);
                Console.WriteLine("El valor de su compra es de: " + X);
                Console.WriteLine("Descuento 15% : " + descuento);
                Console.WriteLine("Total a pagar: " + total);
            }
            Console.ReadKey();
        }
    }
}
