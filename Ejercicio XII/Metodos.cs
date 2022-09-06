using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    internal class Metodos
    {
        public DateTime validarFecha(int numero)
        {
            bool flag = false;
            DateTime fechaValidada;
            string fechaIngresada;

            do
            {
                Console.Write("Por favor, ingrese la fecha " + numero + ": ");
                fechaIngresada = Console.ReadLine();
               

                if (!DateTime.TryParse(fechaIngresada, out fechaValidada))
                {
                    Console.WriteLine("El dato ingresado no corresponde a una fecha, vuelva a intentarlo");
                }
                else
                {
                    flag = true;    
                }

            }while(!flag);

            return fechaValidada;
        }
    }
}
