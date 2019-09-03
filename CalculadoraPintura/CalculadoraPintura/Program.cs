﻿using System;

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
            const double Altura = 2.9;

            Calculadora calculadora = new Calculadora();

            calculadora.areaParede = 2 * (largura + profundidade) * Altura;
            Console.WriteLine(calculadora.areaParede);

            Console.WriteLine("A área do teto é:");
            calculadora.areaTeto = largura * profundidade;
            Console.WriteLine(calculadora.areaTeto);

            Console.WriteLine("A litragem de tinta necessária é :");
            Console.WriteLine((calculadora.areaParede + calculadora.areaTeto) / 10);

            Console.ReadKey();
        }
    }
}
