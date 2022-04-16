using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardLogistico.Core
{
    public class ListNotas
    {
        public List<NotaFiscal> Notas { get; set; }

        public ListNotas(List<NotaFiscal> notas)
        {
            Notas = notas;
        }
        public ListNotas()
        {

        }
    }
}
