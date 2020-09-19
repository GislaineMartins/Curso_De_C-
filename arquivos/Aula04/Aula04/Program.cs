using System;
using System.IO;

namespace Aula04 {
    class Program {
        static void Main(string[] args) {
            string sourcePath = "C:\\Users\\gimcj\\Documents\\temp\\Curso_De_C-\\arquivos\\file1.txt";
            string targetcePath = "C:\\Users\\gimcj\\Documents\\temp\\Curso_De_C-\\arquivos\\file2.txt";

            try {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetcePath)) {
                    foreach (string line in lines) {
                        sw.Write(line.ToUpper());
                    }

                }
            }
            catch (IOException e) {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);

            }
        }
    }
}
