using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardLogistico.Core
{
    public class NotaFiscal
    {
        public long Id { get; set; }
        public string CodCliente { get; set; }
        public string Cliente { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Placa { get; set; }
        public string Motorista { get; set; }
        public string Cooperativa { get; set; }
        public DateTime InicioEntrega { get; set; }
        public DateTime FimEntrega { get; set; }
        public double PesoBruto { get; set; }
        public string NF { get; set; }
        public long SeqProgramada { get; set; }
        public long SeqReal { get; set; }
        public string Identificador { get; set; }
        public string CodAnomalia { get; set; }
        public string Anomalia { get; set; }
        public DateTime DataAnomalia { get; set; }
        public DateTime InicioViagem { get; set; }
        public string Unidade { get; set; }
        public DateTime FimViagem { get; set; }
        public string Baixa { get; set; }
        public double MetrosEntrega { get; set; }
        public double EntregasPrevistas { get; set; }
        public double EntregasRealizadas { get; set; }
        public DateTime FimDescarregamento { get; set; }
        public double Valor { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string SeriePernoite { get; set; }
        public string StatusViagem { get; set; }
        public string Entrega { get; set; }
        public string Linha { get; set; }

        public override string ToString()
        {
            string result = string.Format("Placa: {0} - Identificador: {1} - Cliente: {2} - Data Inicio: {3} - Metros Entrega {4}", Placa, Identificador, Cliente, InicioViagem, MetrosEntrega);
            return result;
        }

    }
}
