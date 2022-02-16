using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeLogica
{
    class Quest6
    {
        public Quest6() { }

        public TimeSpan duracaoPartida(DateTime a, DateTime b)
        {
            System.TimeSpan sub = b.Subtract(a);
            return sub;
        }
    }
}
