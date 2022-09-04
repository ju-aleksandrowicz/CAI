using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    internal class Metodos
    {
        public void validarNumero(ref string entrada, ref int salida)
        {
            bool flag = false;

            do
            {
                Console.Write("Por favor ingrese un numero: ");
                entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out salida))
                {
                    Console.WriteLine("Error! El dato ingresado no es un numero, vuelva a intentarlo.");
                }
                else
                {
                    flag = true;
                }
            } while (!flag);

        }
    }
}
