using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrato.Entites
{
    class HoursContract
    {
        public DateTime date { get; set; }
        public double valuePerHour { get; set; }
        public int hours { get; set; }
        private double resultado;

        public double totalValue()
        {
            return resultado = hours * valuePerHour;
            
        }
    }
}
