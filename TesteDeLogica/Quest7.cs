using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeLogica
{
    class Quest7
    {
        private List<double> numeros = new List<double>();

        public Quest7() { }

        public List<double> getNumeros()
        {
            return numeros;
        }

        //Para deixar mais organizado, resolvi criar um método para adicionar os números na lista
        public void add(double n1)
        {
            numeros.Add(n1);
        }

        public List<double> numerosPares()
        {
            List<double> pares = new List<double>();
            foreach (int numero in numeros)
            {
                if(numero % 2 == 0)
                {
                    pares.Add(numero);
                }
            }

            return pares;
        }
    }
}
