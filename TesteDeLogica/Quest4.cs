using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeLogica
{
    class Quest4
    {
        public Quest4(double c)
        {
            this.C = c;
        }

        public double C { get; set; }

        public double ConverteF()
        {
            return ((9 * this.C) / 5) + 32;
        }
    }
}
