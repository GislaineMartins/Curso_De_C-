using System;
using System.IO;

namespace Aula03 {
    class Program {
        static void Main(string[] args) {

            string path = "C:\\Users\\gimcj\\Documents\\temp\\Curso_De_C-\\arquivos\\file1.txt";
            try {
               
                    using (StreamReader sr = File.OpenText(path)) {
                        while (!sr.EndOfStream) {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }

                


            }
            catch (IOException e) {
                Console.WriteLine("An error ecurred");
                Console.WriteLine(e.Message);
            } 
        }
    }
}
