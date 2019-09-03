namespace CalculadoraPintura
{
    class Calculadora
    {
       public double areaParede;
       public double areaTeto;

        public double CalcularAreaParede(double largura, double profundidade, double altura)    
        {
            areaParede = 2 * (largura + profundidade) * altura;
            return areaParede;
        }
    }
}
