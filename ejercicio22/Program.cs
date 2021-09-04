using System;

namespace ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            int producto, unidades, precio, x;
            double descuento, l;

            Console.WriteLine("Ingrese el codigo del producto:");
            producto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de unitaria del producto:");
            unidades = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el precio unitario del producto:");
            precio = Convert.ToInt32(Console.ReadLine());

            x = unidades * precio;

            if (x >= 50000)
            {
                descuento = x * 0.50;
                l = x - descuento;
                Console.WriteLine("Producto: " + producto);
                Console.WriteLine("Cantidad unitaria: " + unidades);
                Console.WriteLine("Precio unitario: " + precio);
                Console.WriteLine("Total: " + l);
                Console.WriteLine("Descuento 50% : " + descuento);
                Console.WriteLine("Total a pagar: " + l);
            }
            else if (x >= 20000)
            {
                descuento = x * 0.30;
                l = x - descuento;
                Console.WriteLine("Producto: " + producto);
                Console.WriteLine("Cantidad unitaria: " + unidades);
                Console.WriteLine("Precio unitario: " + precio);
                Console.WriteLine("Total: " + x);
                Console.WriteLine("Descuento 30% : " + descuento);
                Console.WriteLine("Total a pagar: " + l);
            }
            else if (x >= 10000)
            {
                descuento = x * 0.10;
                l = x - descuento;
                Console.WriteLine("Producto: " + producto);
                Console.WriteLine("Cantidad unitaria: " + unidades);
                Console.WriteLine("Precio unitario: " + precio);
                Console.WriteLine("Total: " + x);
                Console.WriteLine("Descuento 10% : " + descuento);
                Console.WriteLine("Total a pagar: " + l);
            }
            else
            {
                Console.WriteLine("Producto: " + producto);
                Console.WriteLine("Cantidad unitaria: " + unidades);
                Console.WriteLine("Precio unitario: " + precio);
                Console.WriteLine("No tiene descuento");
                Console.WriteLine("Total a pagar: " + x);
            }
            Console.ReadKey();
        }
    }
}
