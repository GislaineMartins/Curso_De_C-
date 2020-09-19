using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.devides {
   abstract class Device {

        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document);

    }
}
