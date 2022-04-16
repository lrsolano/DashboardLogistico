using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardLogistico.Core
{
    public class DadoIndicador
    {
        public string Agrupamento { get; set; }
        public double Homologacao { get; set; }
        public double Aderencia { get; set; }
        public double Largada { get; set; }
        public long Transportes { get; set; }
    }
}
