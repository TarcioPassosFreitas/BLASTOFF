using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeLogica
{
    class Quest8
    {
        public Quest8() { }

        public Boolean ePrimo(int numero)
        {
            for(int i = 2; i < numero; i++)
            {
                if(numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
