using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso_e1
{
    internal class Metodos
    {
        public void validarRegistro(ref string entrada)
        {
            bool flag = false;
            int salida;           

            do
            {
                Console.Write("Por favor ingrese su numero de registro. Recuerde que debe ser un numero de 6 digitos sin puntos ni comas: ");
                entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out salida)){
                    Console.WriteLine("El dato ingresado no es numerico, vuelva a intentarlo.");
                }
                else if(salida<=0 || salida > 999999)
                {
                    Console.WriteLine("El numero ingresado esta fuera de rango. Vuelva a intentarlo.");
                }
                else
                {
                    flag = true;
                }
            } while (!flag);
        }

        public bool comprobarPrimo(int numero)
        {
            for(int i = 2;i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
