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

            return (areaParede + areaTeto) / 10;
        }


    }
}
