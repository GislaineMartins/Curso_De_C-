using Aula04.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Aula04 {
    class Program {
        static void Main(string[] args) {

            string path = "C:\\Users\\gimcj\\Documents\\temp\\Curso_De_C-\\Interfaces\\in.txt";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream) {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list) {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);

            }
        }
    }
}
