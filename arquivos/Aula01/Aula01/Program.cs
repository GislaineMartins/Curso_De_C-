using System;
using System.IO;

namespace Aula01 {
    class Program {
        static void Main(string[] args) {

            string sourcePath = "C:\\Users\\gimcj\\Documents\\temp\\ws-vs2019\\Curso_De_C-\\arquivos\\file1.txt";
            string targetPath = "C:\\Users\\gimcj\\Documents\\temp\\ws-vs2019\\Curso_De_C-\\arquivos\\file2.txt";

            try {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines) {
                    Console.WriteLine(line);
                }

            }
            catch (IOException e) {
                Console.WriteLine("An erroroccurred ");
                Console.WriteLine(e.Message);

            }

        }
    }
}
