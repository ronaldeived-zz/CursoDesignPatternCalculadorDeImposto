using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto icms = new Icms();
            Imposto iss = new Iss();

            Orcamento orcamento = new Orcamento(500);
            CalculadorDeImposto calculadorDeImposto = new CalculadorDeImposto();

            //Realiza calculo de ICMS
            calculadorDeImposto.RealizaCalculo(orcamento, icms);

            //Realiza calculo de Iss
            calculadorDeImposto.RealizaCalculo(orcamento, iss);

            Console.ReadKey();
        }
    }
}
