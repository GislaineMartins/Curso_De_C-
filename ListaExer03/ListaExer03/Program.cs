using System;

namespace ListaExer03 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite C: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite D: ");
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b - c * d);
            Console.WriteLine("DIFERENCA: " + diferenca);


        }
    }
}
