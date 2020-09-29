using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_PassagemParamParams
{
    class Program
    {
        static void Main(string[] args)
        {
            VariasEntradas01("Victor", "Cesar", "Kaio");

            string[] nome = {"Victor", "Cesar", "Kaio"};

            VariasEntradas02(nome);

            VariasEntradas03(10 ,"Victor", "Cesar", "Kaio","Jesus");

            

           
            

            



        }

        static void VariasEntradas01(string n1, string n2, string n3)
        {

        }

        static void VariasEntradas02(string[] nome)
        {

        }

        static void VariasEntradas03(int num , params string[] nome)
        {

        }

        static void VariasEntradas04(params string[] nomes)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i] + ", ");
            } 
        }
    }
}
