using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ModificadorDAcesso1.Lib
{
    public class Veiculo
    {
        public string Marca;
        protected string Modelo;
        private DateTime AnoFabricacao;
        internal DateTime AnoModelo;

        void infoVeiculo()
        {
            Marca = "Fiat";
            Console.WriteLine(Marca);

            Modelo = "Palio";

            AnoFabricacao = new DateTime(0,0,2000);

            AnoModelo = new DateTime(0, 0, 2000);
        }

    }
}
