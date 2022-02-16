using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeLogica
{
    class Quest9
    {
        public Quest9() { }

        public void tabuada(int num)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i) );
            }
        }
    }
}
