using System;
using System.Threading;

namespace ListaExerc01 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite numero um: ");
            int numUm = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite numero dois: ");
            int numDois = int.Parse(Console.ReadLine());

            int soma = numUm + numDois;

            Console.WriteLine($"Soma = {soma}",soma);



        }
    }
}
