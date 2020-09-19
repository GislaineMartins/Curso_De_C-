using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.devides {
    class Scanner : Device, IScanner {
        public override void ProcessDoc(string document) {
            Console.WriteLine("Scanner processing: "+ document);
        }

        public String Scan() {
            return "Scanner scan result";
        }
    }
}
