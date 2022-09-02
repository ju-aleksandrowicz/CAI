using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej3_repaso
{
    internal class Metodos
    {
        public string darVuelta(string palabra)
        {
            string resultado = "";
            string aux = "";

            for(int i = 1; i <= palabra.Length; i++)
            {
                aux = palabra.Substring(palabra.Length - i, 1);
                resultado = resultado + aux;
            }

            return resultado;
        }
    }
}
