using System;

namespace ListaExercIf06 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um valor: ");
            double valor = double.Parse(Console.ReadLine());

            if (valor >= 0 && valor <= 25) {
                Console.WriteLine("Intervalo [0,25]");
            }else if (valor > 25.01 && valor <= 50) {
                Console.WriteLine("Intervalo (25,50]");
            }else if (valor > 50.01 && valor <= 75) {
                Console.WriteLine("Intervalo (50,75]");
            }else if (valor > 75.01 && valor <= 100) {
                Console.WriteLine("Intervalo (75,100]");
            }
            else {
                Console.WriteLine("Fora de Intervalo");
            }
            
        }
    }
}
