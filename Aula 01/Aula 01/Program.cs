using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Aula_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int numero3;
            int numero4;
            int soma;

            Console.Write("Digite o 1º numero:");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("O valor digitado foi:" + numero1);

            Console.Write("Digite o 2º numero:");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O valor digitado foi:" + numero2);

            Console.Write("Digite o 3º numero:");
            numero3 = int.Parse(Console.ReadLine());
            Console.WriteLine("O valor digitado foi:" + numero3);

            Console.Write("Digite o 4º numero:");
            numero4 = int.Parse(Console.ReadLine());
            Console.WriteLine("O valor digitado foi:" + numero4);

            soma = numero1 + numero2 + numero3 + numero4;

            Console.WriteLine("O valor total foi:" + soma);



            Console.ReadKey(); //Nesse momento o ReadKey serve para o nosso programa não fechar.
        }
    }
}
