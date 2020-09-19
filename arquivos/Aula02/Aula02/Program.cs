using System;
using System.IO;

namespace Aula02 {
    class Program {
        static void Main(string[] args) {
            string path = "C:\\Users\\gimcj\\Documents\\temp\\Curso_De_C-\\arquivos\\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try {
                sr = File.OpenText(path);
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }               
            }
            catch (IOException e) {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally {
                if (sr != null)sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
