using System;
using System.Globalization;

namespace Aula46 {
    class Program {

        
        static void Main(string[] args) {

            Calculadora calc = new Calculadora();

            Console.WriteLine("Entre com o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double  circ = calc.circunferencia(raio);
            double vol = calc.volume(raio);

            Console.WriteLine("Circunferencia: "+ circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " +vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: "+ calc.Pi.ToString("F2",CultureInfo.InvariantCulture));



        }

    }
}
