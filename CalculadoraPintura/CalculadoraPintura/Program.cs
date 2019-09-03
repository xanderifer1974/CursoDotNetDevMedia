using System;

namespace CalculadoraPintura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a largura do cômodo?");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a profundidade do cômodo?");
            double profundidade = double.Parse(Console.ReadLine());

            Console.WriteLine("A área das paredes é:");
            Console.WriteLine(2 * (largura + profundidade)* 2.9);

            Console.WriteLine("A área do teto é:");
            Console.WriteLine(largura * profundidade);

            Console.ReadKey();
        }
    }
}
