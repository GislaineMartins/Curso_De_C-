using System;
using System.Globalization;

namespace Aula42 {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto");
            Console.WriteLine("Nome: ");
            p.nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            p.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no estoque: ");
            p.quantidade = int.Parse(Console.ReadLine());

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
