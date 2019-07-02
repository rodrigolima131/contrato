using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contrato.Entites.Enums;
using Contrato.Entites;

namespace Contrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o departamento: ");
            string depName = Console.ReadLine();

            Console.WriteLine("Enter worker data:");

            Console.Write("Nome :");
            string name = Console.ReadLine();
            Console.Write("Digite o nivel (Junior/MidLevel/Senior) : ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

        }
    }
}
