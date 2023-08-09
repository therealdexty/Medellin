using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a;
            int b;
            int soma;
            int subtracao;
            int multiplicacao;
            int divisao;
            int resto;


            Console.Write("Digite o 1° numero:");
           a = int.Parse(Console.ReadLine() );

            Console.Write("Digite o 2° numero:");
            b = int.Parse(Console.ReadLine() );

            soma = a + b;

            Console.WriteLine("a soma dos valores:" + soma);

            subtracao = a - b;

            Console.Write("A subtração dos valores:" + subtracao);

            Console.ReadKey();





















        }
    }
}
