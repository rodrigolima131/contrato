using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contrato.Entites.Enums;
using Contrato.Entites;
using System.Globalization;

namespace Contrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o departamento: ");
            string depName = Console.ReadLine();

            Console.WriteLine("Dados do trabalhador:");

            Console.Write("Nome :");
            string name = Console.ReadLine();
            Console.Write("Digite o nivel (junior/pleno/senior) : ");
            string nivel = Console.ReadLine();

            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), nivel);
            
         

            Console.Write("Base salario : ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(depName);

            Work worker = new Work(name, level, baseSalary, dept);

            Console.Write("Quantos contratos para esse trabalhador: ");
            int n = int.Parse(Console.ReadLine());

            for(int i =1; i <= n; i++)
            {

                Console.WriteLine("Entre com o contrato #" + i);
                Console.Write("Date (DD/MM/YYYY) : ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("quantidade de horas: ");
                int hours = int.Parse(Console.ReadLine());

                HoursContract contract = new HoursContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine("Entre com o mes e ano para calcular o ganho (MM//YYYY)");

            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Nome: "+worker.Name);
            Console.WriteLine("Departamento: "+worker.Departament.Name);
            Console.WriteLine("Income for "+monthAndYear +": "+worker.Income(year,month));
            Console.ReadKey();
        }
    }
}
