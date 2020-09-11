using System;
using System.Collections.Generic;

namespace Aula76Lista {
    class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Ana");
            list.Add("Juliana");
            list.Insert(2, "Marco");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List Count: "+list.Count);
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

        }

        
    }
}
