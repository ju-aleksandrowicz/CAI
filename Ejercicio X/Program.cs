using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_10
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            /*Ejercicio X
            Crear una aplicación que lea un carácter tecleado por el usuario e indique si se trata 
            de una vocal, una cifra numérica o una consonante. Nota: Incluir todas las validaciones 
            que considere necesarias (los caracteres especiales no deben tenerse en cuenta).*/

            Metodos m = new Metodos();
            char entrada = 'a';

            m.pedirCaracter(ref entrada);
            m.tipoCaracter(entrada);

            Console.WriteLine("Presione una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
