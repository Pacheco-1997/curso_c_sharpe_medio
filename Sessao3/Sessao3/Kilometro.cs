using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessao3
{
    struct Kilometro
    {
        double kilometro;
        double metro;
        double centimetro;

        public double kilometroPraCentimetro(double kilometro)
        {
            metro = kilometro * 1000;
            centimetro = metro * 60;

            return centimetro;
        }
    }
}
