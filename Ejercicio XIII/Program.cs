using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio XIII
            Crear una aplicación que, cuando el usuario ingrese un número, calcule el factorial del mismo y 
            lo muestre por pantalla. 
            Nota: El factorial de un número es el producto de todos los números enteros positivos 
            desde 1 hasta n. Por ejemplo: 5! = 1 x 2 x 3 x 4 x 5 = 120.*/

            Metodos m = new Metodos();

            string datoIngresado = "";
            int numero = 0;

            m.validarNumero(datoIngresado, ref numero);         

            Console.WriteLine("El numero ingresado es: " + m.calcularFactorial(numero) + ".");

            Console.WriteLine("Presione una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
