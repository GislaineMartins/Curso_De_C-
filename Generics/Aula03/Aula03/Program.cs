using Aula03.entities;
using System;

namespace Aula03 {
    class Program {
        static void Main(string[] args) {

            Client a = new Client { Name = "Maria", Email = "maria@gmil.com"};
            Client b = new Client { Name = "Maria", Email = "alex@gmil.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());


        }
    }
}
