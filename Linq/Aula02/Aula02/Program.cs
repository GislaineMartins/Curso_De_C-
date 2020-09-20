using System;

namespace Aula02 {
    class Program {

        public static int glabalValue = 3;
        static void Main(string[] args) {

            int[] vect = new int[] {3, 4, 5 };
            ChangeOddValues(vect);
            Console.WriteLine(string.Join(" ", vect));

        }

        private static void ChangeOddValues(int[] numbers) {
            for (int i=0; i< numbers.Length;i++) {
                if (numbers[i] % 2 != 0) {
                    numbers[i] += glabalValue;
                }

            }
        }
    }
}
