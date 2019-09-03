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
            double areaParede = 2 * (largura + profundidade) * 2.9;
            Console.WriteLine(areaParede);

            Console.WriteLine("A área do teto é:");
            double areaTeto = largura * profundidade;
            Console.WriteLine(areaTeto);

            Console.WriteLine("A litragem de tinta necessária é :");
            Console.WriteLine((areaParede + areaTeto) / 10);

            Console.ReadKey();
        }
    }
}
