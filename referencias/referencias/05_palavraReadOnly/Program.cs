using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_palavraReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine(pessoa.Nome);

            pessoa.teste = Int64.MaxValue;

            Console.WriteLine(pessoa.teste);

            Console.ReadKey();
        }
    }
}
