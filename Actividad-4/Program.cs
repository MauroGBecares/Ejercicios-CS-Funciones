using System;

namespace Actividad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:

            //         a. 1 si el número es positivo.
            //         b. -1 si el número es negativo.
            //         c. 0 si el número es cero.
            int numero, resultado = 900;

            Console.WriteLine("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine());

            positivoNegativoCero(numero, ref resultado);

            Console.WriteLine("El resultado es: " + resultado);


        }

        static void positivoNegativoCero(int a, ref int j)
        {
            if (a > 0)
                j = 1;
            else if (a < 0)
                j = -1;
            else
                j = 0;
        }
    }
}
