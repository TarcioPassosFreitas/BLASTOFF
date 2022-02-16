using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeLogica
{
    class Quest1
    {

        public Quest1(int i, int j, int k, int x, int y)
        {
            this.I = i;
            this.J = j;
            this.K = k;
            this.X = x;
            this.Y = y;
        }

        public int I { get; set; }
        public int J { get; set; }
        public int K { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public double Media()
        {
            double media = 0;
            media = (this.I + this.J + this.K + this.X  + this.Y) / 5;
            return media;
        }




    }
}
