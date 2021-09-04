using System;

namespace ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad, precio, X;
            double descuento;
            double total;

            Console.WriteLine("Ingrese la cantidad de articulos que va comprar:");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor unitario del producto:");
            precio = Convert.ToInt32(Console.ReadLine());

            X = cantidad * precio;

            if (X > 100000)
            {
                descuento = X * 0.20;
                total = X - descuento;
                Console.WriteLine("Cantidad de producto: " + cantidad);
                Console.WriteLine("Valor unitario: " + precio);
                Console.WriteLine("El valor de su compra es de " + X);
                Console.WriteLine("Descuento 20% " + descuento);
                Console.WriteLine("Total a pagar " + total);
            }
            else
            {
                Console.WriteLine("Cantidad de producto: " + cantidad);
                Console.WriteLine("Valor unitario: " + precio);
                Console.WriteLine("sin descuento");
                Console.WriteLine("El valor de su compra es de " + X);
            }
            Console.ReadKey();
        }
    }
}
