using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.devides {
    class ComboDevice : Device, IScanner, Iprinter {
        public void Print(string document) {
            Console.WriteLine("ComboDevice print "+ document);
        }

        public override void ProcessDoc(string document) {
            Console.WriteLine("Combo device processing "+ document);
        }

        public string Scan() {
            return "ComboDevice can result";
        }


    }
}
