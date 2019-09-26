using static System.Console;
using static System.DateTime;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Pessoa()
            {
                Matricula=079756,
                Nome="Alexandre",
                Sobrenome="Ferreira"               
            };
            //WriteLine("Bem vindo " + p.Nome + " " + p.Sobrenome + "(" + p.Matricula + "), este é o C# 1 ");
            //WriteLine(string.Format("Bem vindo {0} {1} ({2}), este é o  C# 6", p.Nome, p.Sobrenome, p.Matricula));
            WriteLine($"Bem vindo {p.Nome} {p.Sobrenome} ({p.Matricula}), este é o C# 6.");//String interpolation.
            WriteLine($"Olá, agora são {Now.ToLongTimeString()}");
            ReadLine();
        }
    }
}
