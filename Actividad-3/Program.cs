using System;

namespace Actividad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
            // Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
            
            int numero, con = 0, acu = 0;
            float promedio;

            Console.WriteLine("Ingrese un nro:");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                if (primo(numero))
                {
                    con++;
                    acu += numero;
                }
            Console.WriteLine("Ingrese un nro:");
            numero = int.Parse(Console.ReadLine());
            }
            promedio = acu / con;
            Console.WriteLine("El promedio de los primos es: " + promedio);
        }

        static bool primo(int a)
        {
            int con = 0;
            for (int x = 1; x <= a; x++)
            {
                if (a % x == 0)
                {
                    con++;
                }    
            }
            if (con == 2)
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
