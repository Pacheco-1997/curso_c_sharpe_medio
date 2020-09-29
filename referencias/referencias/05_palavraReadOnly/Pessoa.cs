using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_palavraReadOnly
{
    class Pessoa
    {
        public readonly string Nome = "Victor";

        public long teste;

        public Pessoa() // metodo construtor
        {
            Nome += " Pacheco";
        }

    }
}
