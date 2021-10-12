using System;

namespace SalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome:");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto:");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto:");
            f.Imposto = double.Parse(Console.ReadLine());
            Console.Write("Funcionário: " + f);

            Console.WriteLine();
            Console.Write("Digite a porcentagem de aumento:");
            double porcentagem = double.Parse(Console.ReadLine());
            f.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.Write("Dados Atualizados: " + f);
        }
    }
}
