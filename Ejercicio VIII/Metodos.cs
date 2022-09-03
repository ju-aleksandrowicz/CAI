using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_8
{
    internal class Metodos
    {
        public void validarFecha(ref string entrada)
        {
            bool flag = false;
            DateTime salida;

            do
            {
                Console.Write("Por favor ingrese una fecha para continuar: ");
                entrada = Console.ReadLine();

                if(!DateTime.TryParse(entrada, out salida))
                {
                    Console.WriteLine("El dato ingresado no corresponde a una fecha, vuelva a intentarlo.");
                }
                else
                {
                    flag = true;
                }

            } while (!flag);

        }
    }
}
