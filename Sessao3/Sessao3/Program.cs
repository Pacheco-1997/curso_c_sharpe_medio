using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessao3
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp;

            Polegada polegada = new Polegada(10);

           // Console.Write(polegada.getPol());

            Kilometro kilometro = new Kilometro();

            Console.WriteLine("Favor digite a quantidade em kilometro para obter em centimetros: ");
            temp = double.Parse(Console.ReadLine());

            Console.WriteLine(temp + " kilometros em centimetros fica: " + kilometro.kilometroPraCentimetro(temp));

            Console.ReadKey();

        }
    }
}
