using System;
using System.Globalization;

namespace Exer02 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int nQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com um preço de um produto? ");
            double precoProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu Ultimo nome, idade e altura:");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(nQuartos);
            Console.WriteLine(precoProduto);
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
