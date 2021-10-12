using System;
using System.Globalization;

namespace AprovacaoAluno
{
    class Aluno
    {
        public string nome;
        public double semestre1;
        public double semestre2;
        public double semestre3;

        public double MediaAluno()
        {
            return (semestre1 + semestre2 + semestre3) / 3;
        }

        public bool AprovacaoAluno()
        {
            if (MediaAluno() >= 60.00)
            {
                Console.WriteLine("Aprovado!");
                return true;
            }
            else
            {
                Console.WriteLine("Reprovado");
                return false;
            }
        }

        public double NotaRestante()
        {
            if (AprovacaoAluno())
            {
                return 0.0;
            }
            else
            {
                return 60.00 - MediaAluno();
            }
        }


        public override string ToString()
        {
            return "Nota Final = "
                + MediaAluno().ToString("F2", CultureInfo.InvariantCulture)
                + "\r\n"
                + "Nota Restante = "
                + NotaRestante().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
