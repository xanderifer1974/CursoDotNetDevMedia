using System;
using static Util.Calc;
using static System.Console;

namespace UsingStatic
{
   
    class Program
    {
        /// <summary>
        /// Declarando um using static, não precisamos colocar a classe estática antes do método.
        /// Não precisou colocar a classe cal e nem console.
        /// Pode ser utilizada para classe parcialmente estática ou totalmente estática. Para as classes
        /// parcialmente estáticas, é necessário instanciar a classe e o método.
        /// </summary>      
        static void Main(string[] args)
        {
            var r = Somar(3, 5);
            WriteLine(r);
            ReadKey();
        }
    }
}
