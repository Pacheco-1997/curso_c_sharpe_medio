using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _02_ModificadorDAcesso1.Lib;

namespace _02_ModificadorDAcesso1
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();
            Carro carro = new Carro();
            Caminhao caminhao = new Caminhao();

            caminhao.Marca = "VOLVO";
            carro.Marca = "FIAR";
            Console.WriteLine(veiculo.Marca);

            carro.AnoModelo = new DateTime(0, 0, 2000);
        }
    }
}
