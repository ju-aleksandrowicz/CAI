using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio VII
            Crear una aplicación que, cuando el usuario ingrese cinco números, indique cuál es mayor,
            cuál es valor intermedio y cuál el menor.*/

            float numMayor = 0;
            float numMedio = 0;
            float numMenor = 0;

            float[] listaDeNumeros = new float[5];
            
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Por favor ingrese el numero " + (i + 1) + ": ");
                listaDeNumeros[i] = Convert.ToSingle(Console.ReadLine());
            }

            for (int j = 0; j < listaDeNumeros.Length-1; j++)
            {
                for (int i = 0; i < listaDeNumeros.Length - 1; i++)
                {
                    float aux;
                    if (listaDeNumeros[i] > listaDeNumeros[i + 1])
                    {
                        aux = listaDeNumeros[i];
                        listaDeNumeros[i] = listaDeNumeros[i + 1];
                        listaDeNumeros[i + 1] = aux;
                    }
                }
            }

            numMayor = listaDeNumeros[4];
            numMedio = listaDeNumeros[2];
            numMenor = listaDeNumeros[0];

            Console.WriteLine("El numero mayor es: " + numMayor);
            Console.WriteLine("El numero medio es: " + numMedio);
            Console.WriteLine("El numero menor es: " + numMenor);

            Console.WriteLine("Presione una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
