using Aula04.service;
using System;

namespace Aula04 {
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program {
        static void Main(string[] args) {

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.showSum;
            op += CalculationService.showMax;

            op.Invoke(a,b);

        }
    }
}
