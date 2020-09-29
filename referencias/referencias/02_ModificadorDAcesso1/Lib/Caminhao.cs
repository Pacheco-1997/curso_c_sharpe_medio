using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02_ModificadorDAcesso1.Lib
{
    public class Caminhao : Veiculo
    {
        byte QdtRodas = 8;

        void InfoCaminhao()
        {
            Modelo = "1520";
            AnoModelo = new DateTime(0, 0, 2000);
        }
        



    }
}
