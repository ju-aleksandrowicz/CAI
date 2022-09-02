using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e4_repaso
{
    internal class Metodos
    {
        public void validarNumero(ref string entrada)
        {
            bool flag = false;
            int salida;

            do
            {
                Console.Write("Por favor ingrese un numero: ");
                entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out salida))
                {
                    Console.WriteLine("El dato ingresado no es numerico, vuelva a intentarlo.");
                }
                else if(entrada.Length != 5){
                    Console.WriteLine("El numero ingresado no es de 5 cifras, vuelva a intentarlo.");
                }
                else
                {
                    flag = true;
                }
            } while (!flag);
        }

        public string darVuelta(string palabra)
        {
            string resultado = "";
            string aux = "";

            for (int i = 1; i <= palabra.Length; i++)
            {
                aux = palabra.Substring(palabra.Length - i, 1);
                resultado = resultado + aux;
            }

            return resultado;
        }
    }
}
