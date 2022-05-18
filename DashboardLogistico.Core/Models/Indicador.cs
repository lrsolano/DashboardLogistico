using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardLogistico.Core
{
    public class Indicador
    {
        public string Regional { get; set; }
        public string Unidade { get; set; }
        public DateTime Data { get; set; }
        public string Identificador { get; set; }
        public string Placa { get; set; }
        public string Cooperativa { get; set; }
        public double Aderencia { get; set; }
        public long Largada { get; set; }
        public long TotalNotas { get; set; }
        public long NotasHomologadas { get; set; }
        public long NotasAderencia { get; set; }
        public double Homologacao { get; set; }
        public string Linha { get; set; }
    }
}
