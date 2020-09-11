using System;

namespace ListaExerc05 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Codigo: 1  ESPECIFICACAO: Cachorro-quente  PRECO: R$4,00 ");
            Console.WriteLine("Codigo: 2  ESPECIFICACAO: X-Salada  PRECO: R$4,50 ");
            Console.WriteLine("Codigo: 3  ESPECIFICACAO: X-Bacon  PRECO: R$5,00 ");
            Console.WriteLine("Codigo: 4  ESPECIFICACAO: Torrada Simples  PRECO: R$2,00 ");
            Console.WriteLine("Codigo: 5  ESPECIFICACAO: Torrada Simples  PRECO: R$1,50 ");

            Console.WriteLine("Digite o codigo: ");
            int codigo = int.Parse(Console.ReadLine());

            if (codigo == 1) {
                Console.WriteLine("Digite a quantidade: ");
                int qtd = int.Parse(Console.ReadLine());
                Console.WriteLine("Total: " + 4 * qtd + " reais");
            } else if (codigo == 2) {
                Console.WriteLine("Digite a quantidade: ");
                int qtd = int.Parse(Console.ReadLine());
                Console.WriteLine("Total: " + 4.5 * qtd + " reais");
            } else if (codigo == 3) {
                Console.WriteLine("Digite a quantidade: ");
                int qtd = int.Parse(Console.ReadLine());
                Console.WriteLine("Total: " + 5 * qtd + " reais");
            }else if (codigo == 4) {
                Console.WriteLine("Digite a quantidade: ");
                int qtd = int.Parse(Console.ReadLine());
                Console.WriteLine("Total: " + 2 * qtd + " reais");
            }else if (codigo == 5) {
                Console.WriteLine("Digite a quantidade: ");
                int qtd = int.Parse(Console.ReadLine());
                Console.WriteLine("Total: " + 1.5 * qtd + " reais");


            }

            

            
        }
    }
}
