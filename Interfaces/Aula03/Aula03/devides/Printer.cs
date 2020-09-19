using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.devides {
    class Printer : Device, Iprinter {
        public override void ProcessDoc(string document) {
            Console.WriteLine("Printer processing: "+ document);
        }

        public void Print(string document) {
            Console.WriteLine("Printer print "+document);

        }
    }
}
