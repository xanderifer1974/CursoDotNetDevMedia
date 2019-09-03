using System;

namespace CalculadoraPintura
{
    class Calculadora
    {
       private double areaParede;
       private double areaTeto;

        public double CalcularAreaParede(double largura, double profundidade, double altura)    
        {
            areaParede = 2 * (largura + profundidade) * altura;
            return areaParede;
        }

        public double CalcularAreaTeto(double largura, double profundidade)
        {
            areaTeto = largura * profundidade;
            return areaTeto;
        }

        public double CalcularLitragemNecessaria()
        {

            if (areaParede == 0 && areaTeto == 0)
            {
                Console.WriteLine("Não é possível calcular a litragem com o valor informado");
                Console.ReadLine();
                Environment.Exit(1);
            }
            return (areaParede + areaTeto) / 10;
        }


    }
}
