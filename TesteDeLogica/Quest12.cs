using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeLogica
{
    class Quest12
    {
        public List<int> a = new List<int> { 1, 2, 3, 4 };
        public List<int> b = new List<int> { 1, 2, 5, 8 };

        public Quest12() { }

        public List<int> concatenacao()
        {
            List<int> c = new List<int>();
            c.AddRange(a);
            foreach (int item in b)
            {
                if (!(a.Contains(item)))
                {
                    c.Add(item);
                }
            }
            return c;
        }
    }
}
