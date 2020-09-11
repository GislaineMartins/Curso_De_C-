using System;
using System.Collections.Generic;
using System.Text;

namespace Aula46 {
    class Calculadora {

        public double Pi = 3.14;


        public double circunferencia(double r) {
            return 2.0 * Pi * r;
        }

        public double volume(double r) {
            return 4.0 / 3 * Pi * Math.Pow(r, 3);
        }

    }
}
