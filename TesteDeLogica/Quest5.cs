using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeLogica
{
    class Quest5 { 
        public Quest5() {
            
        }

        public void multiplos(double n1, double n2)
        {
            if(n1 % n2 == 0) {
                Console.WriteLine("Os números são múltiplos");
            }
            else
            {
                Console.WriteLine("Os números não são múltiplos");
            }
        }


    }
}
