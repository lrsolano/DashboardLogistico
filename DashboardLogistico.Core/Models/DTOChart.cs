using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardLogistico.Core
{
    public class DTOChart
    {
        public string Agrupamento { get; set; }
        public string MesAno { get; set; }
        public double Valor { get; set; }

        public override string ToString()
        {
            return $"{MesAno} - ({Agrupamento}, {Valor})";
        }
    }
}
