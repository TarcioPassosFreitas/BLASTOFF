using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeLogica
{
    internal class Quest11
    {
        public List<int> a = new List<int> {1, 2, 3, 4};
        public List<int> b = new List<int> { 1, 2, 5, 8 };

        public Quest11() { }

        public List<int> interseccao()
        {
            List<int> interseccaolist = new List<int>();
            foreach (int i in a)
            {
                foreach(int j in b)
                {
                    if (i == j)
                    {
                        interseccaolist.Add(i);
                    }
                }
            }
            return interseccaolist;
        }
    }
}
