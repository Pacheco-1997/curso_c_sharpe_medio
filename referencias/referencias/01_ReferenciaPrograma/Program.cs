using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Biblioteca;

namespace _01_ReferenciaPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoJuros calc = new CalculoJuros();

            Console.WriteLine(calc.Soma(2,6));
        }
    }
}
