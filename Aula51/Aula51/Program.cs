using System;
using System.Globalization;

namespace Aula51 {
    class Program {
        static void Main(string[] args) {
          

            Console.WriteLine("Entre com os dados do produto");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

             Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine("Dados do produto: "+p);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser adicionado");
            int qtd = int.Parse(Console.ReadLine());
            p.adicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser removido");
            qtd = int.Parse(Console.ReadLine());
            p.removerProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
