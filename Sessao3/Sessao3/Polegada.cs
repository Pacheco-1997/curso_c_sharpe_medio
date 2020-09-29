using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessao3
{
    struct Polegada
    {
        double centimetro;

        double polegada;

        public Polegada(double polegadas)
        {
            centimetro = 2.4;
            polegada = centimetro * polegadas;
        }

        public double getPol()
        {
            return polegada;
        }
    }
}
