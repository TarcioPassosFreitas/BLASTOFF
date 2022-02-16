using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeLogica
{
    internal class Quest14
    {
        public Quest14() { }

        public Boolean ePalindromo(String texto)
        {
            texto = texto.ToLower();
            String textoInvertido = new string(texto.Reverse().ToArray());
            if (texto.Equals(textoInvertido)) { return true; }
            else { return false; }
        }
    }
}
