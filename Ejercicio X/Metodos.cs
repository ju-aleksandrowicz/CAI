using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_10
{
    internal class Metodos
    {
        public void pedirCaracter(ref char entrada)
        {
            bool flag = false;
            string respuesta = "";

            do
            {
                Console.Write("Por favor ingrese un caracter: ");
                respuesta = Console.ReadLine(); 

                if(!char.TryParse(respuesta, out entrada))
                {
                    Console.WriteLine("El dato ingresado no es un caracter, vuelva a intentarlo.");
                }
                else
                {
                    flag = true;
                }
            } while (!flag);
        }

        public void tipoCaracter(char entrada)
        {
            string aux = entrada.ToString();
            aux = aux.ToLower();

            if (int.TryParse(aux, out int salida))
            {
                Console.WriteLine("El caracter ingresado es un numero.");
            }
            else if (aux == "a" || aux == "e" || aux == "i" || aux == "o" || aux == "u")
            {
                Console.WriteLine("El caracter ingresado es una vocal.");
            }
            else
            {
                Console.WriteLine("El caracter ingresado es una consonante.");
            }
        }
    }
}
