using System;
using System.IO;



namespace Aula05 {
    class Program {
        static void Main(string[] args) {
            string path = "C:\\Users\\gimcj\\Documents\\temp\\Curso_De_C-\\arquivos\\myfolder";

            try {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders) {
                    Console.WriteLine(s);
                }
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files) {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "\\newfolder");
            }
            catch (IOException e) {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);

            }
        }
    }
}
