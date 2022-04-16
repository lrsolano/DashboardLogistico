using DashboardLogistico.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardLogistico.Data
{
    public static class QueryGenerator
    {
        public static string QueryToHomologacao(Filtros filtros)
        {
            StringBuilder query = new StringBuilder();

            query.Append("SELECT ");
            query.Append($"{filtros.Group}, strftime('%m-%Y', data) dataInicio, ");
            query.Append(@"avg(Homologacao) Homologacao FROM Indicadores ");
            query.Append(GenerateWhereIndicadores(filtros));
            query.Append($" group by {filtros.Group}, dataInicio;");

            return query.ToString();
        }

        public static string QueryToDataIndicadores(Filtros filtros)
        {
            StringBuilder query = new StringBuilder();

            query.Append("SELECT ");
            query.Append($"{filtros.Group} Agrupamento, ");
            query.Append(@" avg(Aderencia) Aderencia, avg(Homologacao) Homologacao, avg(Largada) Largada, count(identificador) Transportes  FROM Indicadores ");
            query.Append(GenerateWhereIndicadores(filtros));
            query.Append($" group by {filtros.Group}; ");

            return query.ToString();
        }

        public static string QueryAderencia(Filtros filtros)
        {
            StringBuilder query = new StringBuilder();

            query.Append("SELECT ");
            query.Append($"{filtros.Group}, strftime('%m-%Y', data) dataInicio, ");
            query.Append(@"avg(Aderencia) Aderencia FROM Indicadores ");
            query.Append(GenerateWhereIndicadores(filtros));
            query.Append($" group by {filtros.Group}, dataInicio;");

            return query.ToString();
        }

        public static string QueryToLargada(Filtros filtros)
        {
            StringBuilder query = new StringBuilder();

            query.Append("SELECT ");
            query.Append($"{filtros.Group}, strftime('%m-%Y', data) dataInicio, ");
            query.Append(@"avg(Largada) Largada FROM Indicadores ");
            query.Append(GenerateWhereIndicadores(filtros));
            query.Append($" group by {filtros.Group}, dataInicio;");

            return query.ToString();
        }

        public static string QueryToJornada(Filtros filtros)
        {
            StringBuilder query = new StringBuilder();

            query.Append("select distinct Placa, strftime('%d-%m-%Y', InicioViagem) dataInicio, ((JulianDay(FimViagem) - JulianDay(InicioViagem))*24) Jornada");
            query.Append(@" FROM Notas ");
            query.Append(GenerateWhere(filtros));
            query.Append(" order by 1,2;");

            return query.ToString();
        }

        public static string QueryToDescarga(Filtros filtros)
        {
            StringBuilder query = new StringBuilder();

            query.Append("select distinct Cliente, CodCliente, strftime('%d-%m-%Y', InicioViagem) dataInicio, ((JulianDay(FimEntrega) - JulianDay(InicioEntrega))*24) Tempo");
            query.Append(@" FROM Notas ");
            query.Append(GenerateWhere(filtros));
            query.Append(" order by 1,2;");

            return query.ToString();
        }

        public static string QueryToFilter(Filtros filtros, string campo)
        {
            StringBuilder query = new StringBuilder();

            query.Append($"select 'Todos' union ");
            query.Append($"select distinct {campo} ");
            query.Append(@" FROM Notas ");
            query.Append(GenerateWhere(filtros));
            query.Append(" order by 1;");

            return query.ToString();
        }

        internal static string GenerateWhere(Filtros filtros)
        {
            DateTime dataInicio = new DateTime(2000, 1, 1);

            StringBuilder where = new StringBuilder();

            where.Append(" WHERE ");

            where.Append($" InicioViagem > '{dataInicio.ToString("yyyy-MM-dd HH:mm:ss")}' ");

            where.Append($" AND InicioViagem >= '{filtros.DataInicio.ToString("yyyy-MM-dd HH:mm:ss")}' ");
            where.Append($" AND InicioViagem <= '{filtros.DataFim.ToString("yyyy-MM-dd HH:mm:ss")}' ");

            if (filtros.Cliente != "Todos") where.Append($" AND UPPER(Cliente) LIKE UPPER('%{filtros.Cliente}%') ");
            if (filtros.Cooperativa != "Todos") where.Append($" AND UPPER(Cooperativa) LIKE UPPER('%{filtros.Cooperativa}%') ");
            if (filtros.Unidade != "Todos") where.Append($" AND UPPER(Notas.Unidade) LIKE UPPER('%{filtros.Unidade}%') ");
            if (filtros.CodCliente != "Todos") where.Append($" AND UPPER(CodCliente) LIKE UPPER('%{filtros.CodCliente}%') ");
            if (filtros.Identificador != "Todos") where.Append($" AND UPPER(Identificador) LIKE UPPER('%{filtros.Identificador}%') ");

            

            return where.ToString();

        }

        internal static string GenerateWhereIndicadores(Filtros filtros)
        {

            StringBuilder where = new StringBuilder();

            where.Append(" WHERE ");

            where.Append($" data >= '{filtros.DataInicio.ToString("yyyy-MM-dd HH:mm:ss")}' ");
            where.Append($" AND data <= '{filtros.DataFim.ToString("yyyy-MM-dd HH:mm:ss")}' ");

            if (filtros.Cooperativa != "Todos") where.Append($" AND UPPER(Cooperativa) LIKE UPPER('%{filtros.Cooperativa}%') ");
            if (filtros.Unidade != "Todos") where.Append($" AND UPPER(Unidade) LIKE UPPER('%{filtros.Unidade}%') ");
            if (filtros.Identificador != "Todos") where.Append($" AND UPPER(Identificador) LIKE UPPER('%{filtros.Identificador}%') ");



            return where.ToString();

        }
    }
}
