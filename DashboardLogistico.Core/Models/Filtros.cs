using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardLogistico.Core
{
    public class Filtros
    {
        public string Group { get; set; }
        public string Unidade { get; set; }
        public string Cooperativa { get; set; }
        public string Cliente { get; set; }
        public string CodCliente { get; set; }
        public string Identificador { get; set; }
        public long HoraMaximaEntregaMinutos { get; set; }
        public long HoraMaximaJornadaHoras { get; set; }
        public long RaioMaximoMetros { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
