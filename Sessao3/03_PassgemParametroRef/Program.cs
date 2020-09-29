using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PassgemParametroRef
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 25;
            //double valor1 = 10;

            Console.WriteLine("Este é valor {0}", valor);

            AlteraValor(ref valor);

            Console.WriteLine("Este é valor {0}", valor);

            Console.ReadKey();
        }

        public static void AlteraValor(ref double valor)
        {
            valor = valor * 2;
            Console.WriteLine("Este é valor {0}", valor);
        }
    }
}
