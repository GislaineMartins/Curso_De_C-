using System;
using System.Globalization;

namespace Aula61Exer {
    class Program {
        static void Main(string[] args) {
            ContaBancaria conta;

            Console.Write("Digite o numero da conta:");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta:");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n)? :");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S') {
                Console.Write("Digite o valor inicial? :");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta");
            Console.WriteLine(conta);

            Console.WriteLine("Digite um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);

            Console.WriteLine("Digite um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);


        }
    }
}

