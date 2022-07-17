using System;

namespace Index
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantidade De Valores Somados");

            int qnt = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 0; i < qnt; i++)
            {
                
                Console.WriteLine("Número [" + i + "]:");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            soma = soma / qnt;
            Console.WriteLine("Resultado: " + soma);
        }
    }
}