using System;


namespace ListaExcerIf01 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite numero um: ");
            int numUm = int.Parse(Console.ReadLine());

            if (numUm < 0) {
                Console.WriteLine("NEGATIVO: ");
            }
            else {
                Console.WriteLine("POSITIVO: ");
            }         




        }
    }
}
