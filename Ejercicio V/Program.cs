using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e4_repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio V
            Crear una aplicación que, cuando el usuario ingresa un número de 5 cifras, lo invierta y 
            muestre por pantalla “El número invertido es: nnnnn”. Por ejemplo, si el usuario ingresa “12345”,
            mostrará por pantalla “54321”.*/

            Metodos m = new Metodos();

            string entrada = "";
            string numeroDadoVuelta = "";

            m.validarNumero(ref entrada);
            numeroDadoVuelta = m.darVuelta(entrada);

            Console.WriteLine("El numero invertido es: " + numeroDadoVuelta);

            Console.WriteLine("Presione una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
