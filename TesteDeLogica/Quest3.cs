using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeLogica
{
    class Quest3
    {
        public Quest3()
        {
        }



        public double MenorNumero(double a, double b, double c)
        {
            if(a < b && a < c)
            {
                return a;
            }else if (b < a && b < c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
