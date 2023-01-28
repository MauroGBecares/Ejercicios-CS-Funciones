using System;

namespace Actividad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
            // Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

            int numero, con = 0;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un numero:");
                numero = int.Parse(Console.ReadLine());

                if (par(numero))
                {
                    con++;
                }
            }
            Console.WriteLine("La cantidad de numero pares es: " + con);
        }

        static bool par(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
