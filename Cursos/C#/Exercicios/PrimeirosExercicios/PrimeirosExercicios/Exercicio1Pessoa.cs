using System;

namespace PrimeirosExercicios
{
    class Exercicio1Pessoa
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Digite o nome da primera Pessoa:");
            pessoa1.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da primera Pessoa:");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda Pessoa:");
            pessoa2.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda Pessoa:");
            pessoa2.idade = int.Parse(Console.ReadLine());

            if(pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine(pessoa1.nome + " é a pessoa mais velha");
            }
            else {
                Console.WriteLine(pessoa2.nome + " é a pessoa mais velha");
            }
            
        }
    }
}
