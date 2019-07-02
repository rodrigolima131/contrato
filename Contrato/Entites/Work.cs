using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contrato.Entites.Enums;
namespace Contrato.Entites
{
    class Work
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HoursContract> Contracts { get; set; } = new List<HoursContract>();

        public Work(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;


        }

        public void AddContract(HoursContract contract)
        {
            Contracts.Add(contract);


        }

        public void RemoveContract(HoursContract contract)
        {
            Contracts.Remove(contract);
        }

        
        public double Income(int year,int month)
        {
            double sum = BaseSalary;
            foreach(HoursContract contract in Contracts)
            {

                if(contract.date.Year == year && contract.date.Month == month)
                {
                    sum += contract.totalValue();
                }
            }
            return sum;
        }

    }

    
}
