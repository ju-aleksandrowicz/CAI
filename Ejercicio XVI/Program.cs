using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio XVI
            Crear una aplicación que, cuando el usuario ingrese un número, lo muestre por pantalla
            e indique cuántos dígitos tiene. Si el usuario ingresa 5629, mostrará 
            “Número ingresado: 5629 – Tiene 4 dígitos”.*/

            Metodos m = new Metodos();

            string datoIngresado = "";
            int numeroIngresado = 0;

            m.validarNumero(ref datoIngresado, ref numeroIngresado);

            Console.WriteLine("Número ingresado: " + numeroIngresado + " – Tiene " + datoIngresado.Length + " dígitos.");

            Console.WriteLine("Presione una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
