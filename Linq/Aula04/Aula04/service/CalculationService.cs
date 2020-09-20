using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.service {
    class CalculationService {

        public static void showMax(double x, double y) {
            double max = (x > y) ? x : y;
            Console.WriteLine(max);
        }

        public static void showSum(double x, double y) {
            double sum = x + y;
            Console.WriteLine(sum);
        }


    }
}
