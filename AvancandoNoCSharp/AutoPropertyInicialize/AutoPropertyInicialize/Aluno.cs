using System;

public class Aluno
{
    public static int Matricula { get; set; } = 0;
    public string Nome { get; set; } = "Sem nome";
    public string Status { get; set; } = Matricula == 0 ? "Não Matriculado" : "Matriculado";
}
