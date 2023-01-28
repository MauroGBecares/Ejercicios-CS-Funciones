using System;

namespace Actividad_1
{
    class Program
    {
        static void Main(string[] args)
        {
        //   1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
        //   Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.
            int precioArt, CanVendida, MotTotal;

            Console.WriteLine("Ingrese el precio del articulo:");
            precioArt = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida:");
            CanVendida = int.Parse(Console.ReadLine());

            MotTotal = producto(precioArt, CanVendida);

            Console.WriteLine("El monto total a pagar es: " + MotTotal);

        }

        static int producto(int a, int b)
        {
            int resultado;
            resultado = a * b;
            return resultado;
        }
    }
}
