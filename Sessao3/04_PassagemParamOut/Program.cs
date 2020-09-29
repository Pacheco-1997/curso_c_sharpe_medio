using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PassagemParamOut
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 25;
            int idade;
            //double valor1 = 10;

            Console.WriteLine("Este é valor {0}", valor);

            AlteraValor(out valor);

            string nome = retornaIdadePessoa(new DateTime(10,10,2020), out idade);

            Console.WriteLine(idade);

            Console.WriteLine("Este é valor {0}", valor);

            Console.ReadKey();
        }

        public static void AlteraValor(out double valor)
        {
            valor = 100 ;
            
        }
        static string retornaIdadePessoa(DateTime dataNasc, out int idade)
        {
            idade = 23;
            return "Nome";
        }
    }
}
