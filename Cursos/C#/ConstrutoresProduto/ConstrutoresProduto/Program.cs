using System;

namespace SegundoProblemaProduto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os dados do produto");
            /*Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());*/

            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV 4K";

            //p.SetNome("T");
            /*Produto p2 = new Produto(nome, preco);

            Produto p3 = new Produto { 
                p.SetNome("TV 4K"),
                Preco = 500.00, 
                Quantidade = 20 };*/



            //Console.WriteLine(p.GetNome());
            Console.WriteLine(p.Nome);
            Console.WriteLine();
            Console.Write("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados Atualizados: " + p);

        }
    }
}
