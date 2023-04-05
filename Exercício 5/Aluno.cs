using System;
using System.Globalization;

namespace Exercício_5
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public double DiferencaReprovado()
        {
            return 60.0 - NotaFinal();
        }
        public string ResultadoFinal()
        {
            if (NotaFinal() >= 60.0)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO \nFALTARAM " + DiferencaReprovado().ToString("F2",CultureInfo.InvariantCulture) + " PONTOS";
            }
        }        
        public override string ToString()
        {
            return ResultadoFinal();
            
        }

    }
}
