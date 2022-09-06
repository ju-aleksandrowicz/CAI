using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio XX
            Crear una aplicación que, cuando el usuario ingrese un número, indique la cantidad de números primos entre el cero y él, y su factorial.
            Por ejemplo, si el usuario ingresa 5, indicará “Hasta el 5 hay 3 números primos y el factorial de 5 es 120”.*/

            Metodos m = new Metodos();

            string datoIngresado = "";
            int numeroValidado = 1;
            int contadorPrimos = 0;

            m.validarNumero(datoIngresado, ref numeroValidado);

            for (int i = 1; i <= numeroValidado; i++)
            {
                if (m.comprobarPrimo(i))
                {
                    contadorPrimos++;
                }
            }

            Console.WriteLine("Hasta el " + numeroValidado +" hay " + contadorPrimos + " números primos y el factorial de " + numeroValidado + " es " + m.calcularFactorial(numeroValidado) + ".");

            Console.WriteLine("Presione una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
