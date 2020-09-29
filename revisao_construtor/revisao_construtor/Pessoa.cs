using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao_construtor
{
    class Pessoa
    {
        public string Nome;
        string Sexo;
        DateTime DataNasc;
        double px, py; 

        public Pessoa(string nome, string sexo, DateTime datanascimento, double x, double y)
        {
            Nome = nome;
            Sexo = sexo;
            DataNasc = datanascimento;
            px = x;
            py = y; 
        }
    }
}
