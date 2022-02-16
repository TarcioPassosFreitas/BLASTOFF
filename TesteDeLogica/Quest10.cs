using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeLogica
{
    class Quest10
    {
        public Quest10() { }

        public long Fatorial(long valor)
        {
            long fat = 1;
            for(long i = 2; i <= valor; i++)
            {
                fat *= i;
            }
            return fat;
        }
    }
}
