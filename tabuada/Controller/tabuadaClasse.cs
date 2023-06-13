using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada.Controller
{
    internal class tabuadaClasse
    {
        //metodo do calcular a tabuada
        public string CalcularTabuada(int valor)
        {
            string valorCalculo = "";

            for (int i =0; i < 10; i++ )
            {
                valorCalculo += valor + "x" + i + "=" + valor * i;
            }
            return valorCalculo;
        }

        //metodo de limpar registros


    }
}
