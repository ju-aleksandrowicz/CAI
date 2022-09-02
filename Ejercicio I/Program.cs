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
            /*Ejercicio I
            Crear una aplicación que cuente desde el número 1 hasta los últimos tres dígitos del
            propio número de registro (en caso de ser comenzar con 0, sumarle 100), todos los
            números deben mostrarse por pantalla y, con los múltiplos de 3 se debera agregar
            “Foo”, con los múltiplos de 5, “Bar”, y, por último, con los múltiplos de ambos, “FooBar”.
            Por ejemplo, con el número mostrará “15 – FooBar”. */

            string respuesta;
            int numeroAContar;

            Console.Write("Ingrese su numero de registro: ");
            respuesta = Console.ReadLine();

            numeroAContar = Convert.ToInt32(respuesta.Substring(3));

            if(numeroAContar < 100)
            {
                numeroAContar += 100;
            }

            for(int i = 1; i <= numeroAContar; i++)
            {
                if((i % 3) == 0 && (i % 5) == 0)
                {
                    Console.WriteLine(i + " - FooBar");
                }
                else if((i % 3) == 0)
                {
                    Console.WriteLine(i + " - Foo");
                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine(i + " - Bar");
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
