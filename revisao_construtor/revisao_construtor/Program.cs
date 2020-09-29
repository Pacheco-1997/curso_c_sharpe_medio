using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao_construtor
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa = new Pessoa("victor","masculino", new DateTime(1997,11,25),25,50);

            Console.Write(pessoa.Nome);

            Console.ReadKey();
        }
    }
}
