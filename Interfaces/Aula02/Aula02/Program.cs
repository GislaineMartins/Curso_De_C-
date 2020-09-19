using Aula02.model.entities;
using Aula02.model.enums;
using System;

namespace Aula02 {
    class Program {
        static void Main(string[] args) {

            IShape s1 = new Circle() { Radius = 2.0, Color = Color.write };
            IShape s2 = new Retangle() { Width = 3.5, Height = 4.2, Color = Color.Black };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
