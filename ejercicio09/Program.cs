using System;

namespace ejercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            string producto;
            int unidades, precio, iva;
            int resultado, total, pago;

            Console.WriteLine("ingrese la referencia del producto :");
            producto = Convert.ToString(Console.ReadLine());
            Console.WriteLine("ingrese la unidades del producto " + producto + " :");
            unidades = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el percio del producto (sin iva) :");
            precio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el porcentaje del iva : ");
            iva = Convert.ToInt32(Console.ReadLine());

            resultado = unidades * precio;
            total = (resultado * iva) / 100;
            pago = resultado + total;

            Console.WriteLine("Producto " + producto);
            Console.WriteLine("Cantidad " + unidades);
            Console.WriteLine("Total " + resultado);
            Console.WriteLine("Iva " + iva + "%");
            Console.WriteLine("Total a pagar " + pago);
            Console.ReadKey();
        }
    }
}
