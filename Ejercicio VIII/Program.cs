using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio VIII
            Crear una aplicación que, cuando el usuario ingrese una fecha, calcule la diferencia 
            entre ésta y el día de hoy, mostrando por pantalla "La diferencia de fechas es de nnnnn días."*/

            Metodos m = new Metodos();

            string entrada = "";
            DateTime salida;
            int diferencia;

            m.validarFecha(ref entrada);

            salida = Convert.ToDateTime(entrada);

            diferencia = (DateTime.UtcNow - salida).Days;
            Console.WriteLine("La diferencia de fechas es de " + diferencia + " dias.");

            Console.WriteLine("Presione una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
