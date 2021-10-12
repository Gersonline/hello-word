using System;

namespace AprovacaoAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno:");
            aluno.nome = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas do Aluno");
            aluno.semestre1 = double.Parse(Console.ReadLine());
            aluno.semestre2 = double.Parse(Console.ReadLine());
            aluno.semestre3 = double.Parse(Console.ReadLine());

            Console.WriteLine(aluno);


        }
    }
}
