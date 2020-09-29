using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PassagemParametroPVal
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 25;

            Console.WriteLine("Este é valor {0}", valor);

            AlteraValor(valor);

            Console.WriteLine("Este é valor {0}", valor);

            Console.ReadKey();
        }

        public static void AlteraValor(double valor)
        {
            valor = valor * 2;
            Console.WriteLine("Este é valor {0}", valor);
        }

    }
}
