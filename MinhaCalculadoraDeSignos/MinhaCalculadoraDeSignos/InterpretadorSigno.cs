using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCalculadoraDeSignos
{
    class InterpretadorSigno
    {
        public Signo Interpretar(int dia, int mes)
        {
            Signo signo = null;
            if((dia >= 19 && mes == 2) || (dia <= 20 && mes == 3))
            {

                signo = new Signo();
                signo.nome = "Peixes";
            }
            return signo;
        }
    }
}
