using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AutoImplement2
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa = new Pessoa();

            pessoa.Nome = "Victor";

            Console.WriteLine(pessoa.Nome);

            Console.ReadKey();
        }
    }
}
