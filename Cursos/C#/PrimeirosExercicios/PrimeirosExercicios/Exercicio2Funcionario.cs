using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosExercicios
{
    class Exercicio2Funcionario
    {
        static void Main(string[] args)
        {
            Funcionario func1, func2;
            func1 = new Funcionario();
            func2 = new Funcionario();

            Console.WriteLine("Dados do Primeiro Funcionario: ");
            Console.Write("Nome: ");
            func1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            func1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Segundo Funcionario: ");
            Console.Write("Nome: ");
            func2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            func2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (func1.salario + func2.salario) / 2;
            Console.WriteLine("Média salárial: " + media.ToString("F4", CultureInfo.InvariantCulture));
        }   
    }
}
