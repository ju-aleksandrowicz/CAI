using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso_e1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio II
            Crear una aplicación que cuente desde el número 1 hasta los últimos tres dígitos del propio
            número de registro (en caso de ser comenzar con 0, sumarle 100) e identificar los múltiplos
            de 3 y, también, aquellos que sean números primos. Para ambos casos (múltiplo de 3 y primos),
            deben mostrar el número en cuestión y " Es divisible por 3", "Es primo" y, en caso de ser
            ambos “Es primo y divisible por 3”. Por ejemplo, con el primer número mostrará “1 – Es primo”.*/

            Metodos m = new Metodos();

            string respuesta = "";
            int numeroAContar;

            m.validarRegistro(ref respuesta);

            numeroAContar = Convert.ToInt32(respuesta.Substring(3));

            if(numeroAContar < 100)
            {
                numeroAContar += 100;
            }

            for(int i = 1; i <= numeroAContar; i++)
            {
                if((i % 3) == 0 && (m.comprobarPrimo(i)))
                {
                    Console.WriteLine(i + " - Es primo y divisible por 3");
                }
                else if((i % 3) == 0)
                {
                    Console.WriteLine(i + " - Es divisible por 3");
                }
                else if (m.comprobarPrimo(i))
                {
                    Console.WriteLine(i + " - Es primo");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Presione una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
