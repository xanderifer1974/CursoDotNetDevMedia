using static System.Console;

namespace AutoPropertyInicialize
{
    class Program
    {
        static void Main(string[] args)
        {
            var gp = new Aluno()
            {
                
                Nome = "Natan Spinelli Ferreira"
            };
                       

            WriteLine($"O Aluno {gp.Nome}, matrícula - {Aluno.Matricula}, foi aprovado com sucesso!!! >> {gp.Status}");
            ReadLine();
        }
    }
}
