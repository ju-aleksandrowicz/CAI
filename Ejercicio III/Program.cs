using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej3_repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio III
            Crear una aplicación que indique, cuando el usuario ingresa una palabra, si ésta es un palíndromo.
            Nota: Palíndromo son palabras que al derecho y al revés se leen igual, como "ananá".*/

            Metodos m = new Metodos();

            string respuesta;
            string respuestaDadaVuelta;

            Console.Write("Por favor ingrese una palabra y comprobaremos si es un palindromo: ");
            respuesta = Console.ReadLine();

            respuestaDadaVuelta = m.darVuelta(respuesta);

            if (respuesta == respuestaDadaVuelta)
            {
                Console.WriteLine("La palabra ingresada es un palindromo, ya que " + respuesta + " se escribe igual al derecho y al reves.");
            }
            else
            {
                Console.WriteLine("La palabra ingresada no es un palindromo.");
            }

            Console.WriteLine("Presione una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
