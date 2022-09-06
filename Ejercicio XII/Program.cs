using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio XII
            Crear una aplicación que, cuando el usuario ingrese dos fechas distintas, 
            calcule la diferencia entre éstas y la muestre por pantalla, indicando años, 
            meses y días por separado (en base 365). Por ejemplo, si ingreso 
            las fechas 23/09/1993 y 09/04/1997, la aplicación devolverá por pantalla 
            “La diferencia es de 3 años, 6 meses y 19 días”.*/

            Metodos m = new Metodos();
            DateTime primeraFecha;
            DateTime segundaFecha;
            TimeSpan diferencia;
            int diferenciaNum;
            int diffAnios;
            int diffMeses;
            int diffDias;

            primeraFecha = m.validarFecha(1);
            segundaFecha = m.validarFecha(2);

            diferencia = primeraFecha - segundaFecha;

            diferenciaNum = Math.Abs((diferencia.Days));
            diffAnios = diferenciaNum / 365;
            diffMeses = (diferenciaNum - (diffAnios * 365))/(365/12);
            diffDias = (diferenciaNum-(diffAnios*365)-(diffMeses*(365/12)));

            Console.WriteLine("La diferencia entre las fechas es de " + diffAnios + " años, " +
            diffMeses + " meses y " + diffDias + " días.");
            Console.WriteLine(diferenciaNum);
            
            Console.WriteLine("Presione una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
