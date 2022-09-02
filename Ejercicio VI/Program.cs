using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioVI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio VI
            Crear una aplicación que, cuando el usuario ingrese dos números, realice la operación 
            aritmética (a+b)*(a-b) e indique por pantalla el resultado.*/

            float primerNumero;
            float segundoNumero;
            float resultado;

            Console.Write("Por favor ingrese el primer numero: ");
            primerNumero = Convert.ToSingle(Console.ReadLine());
            Console.Write("Por favor ingrese el segundo numero: ");
            segundoNumero = Convert.ToSingle(Console.ReadLine());

            resultado = ((primerNumero + segundoNumero) * (primerNumero - segundoNumero));

            Console.WriteLine("El resultado de la operación aritmética (a + b) * (a - b) es: " + resultado);

            Console.WriteLine("Presione una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
