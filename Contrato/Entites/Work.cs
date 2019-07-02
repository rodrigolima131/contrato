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
        public string name { get; set; }
        public WorkerLevel level { get; set; }
        public double baseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HoursContract> Contracts { get; set; } = new List<HoursContract>();

        public Work(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            this.name = name;
            this.level = level;
            this.baseSalary = baseSalary;
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
            double sum = baseSalary;
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
