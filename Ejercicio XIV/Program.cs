using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio XIV
            Crear una aplicación que, cuando el usuario ingrese un número, 
            muestre su tabla de multiplicar por pantalla.*/

            Metodos m = new Metodos();

            string datoIngresado = "";
            int numeroIngresado = 1;

            m.validarNumero(datoIngresado, ref numeroIngresado);
            m.mostrarTabla(numeroIngresado);

            Console.WriteLine("Presione una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
