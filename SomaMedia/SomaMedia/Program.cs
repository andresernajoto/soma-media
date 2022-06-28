using System;

namespace SomaMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0.0;
            double media = 1.0;

            Console.Write("Digite quantos números quer inserir: ");
            double num = double.Parse(Console.ReadLine());

            if (num < 3 || num > 10)
            {
                Console.WriteLine("\nVocê digitou uma quantidade fora do permitido!\nAplicação finalizada");
                Environment.Exit(0);
            }

            for (int i = 0; i < num; i++)
            {
                Console.Write("Digite de 3 a 10 números: ");
                double listOfNums = double.Parse(Console.ReadLine());
                soma += listOfNums;
            }

            media = soma / num;

            Console.WriteLine("\nA soma entre os valores digitados é {0}", soma);
            Console.WriteLine("A média entre os valores digitados é {0}", media);
        }
    }
}
