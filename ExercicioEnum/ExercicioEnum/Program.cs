using ExercicioEnum.Entities;
using ExercicioEnum.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioEnum {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter departament's name: ");
            string depName = Console.ReadLine();
            Console.WriteLine("Enter Work data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level (Junior/MidLevel/Senior):  ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base salary");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(depName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i=0; i<n;i++) {
                Console.Write("Enter "+ i+" contract data: ");
                Console.Write("Date (DD/MM/YYYY) ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duraion (hours):");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);

            }

            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY)");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: "+ worker.Name);
            Console.WriteLine("Departament: "+ worker.Departament.Name);
            Console.WriteLine("Income for "+ monthAndYear + ": "+worker.Income(year, month));

        }
    }
}
