using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardLogistico.Core
{
    public class NotaFiscalRepositoryException : Exception
    {
        public NotaFiscalRepositoryException()
        {

        }
        public NotaFiscalRepositoryException(string message): base(message)
        {

        }
        public NotaFiscalRepositoryException(string message, Exception innerException): base(message, innerException)
        {

        }
    }
}
