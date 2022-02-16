using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeLogica
{
    class Quest2
    {
        public Quest2(double a, double b)
        {
            this.A = a;
            this.B = b;
        }

        public double A { get; set; }
        public double B { get; set; }

        public double consumoMedio()
        {
            return (this.A / this.B);
        }
    }
}
