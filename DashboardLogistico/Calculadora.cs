using DashboardLogistico.Core;
using DashboardLogistico.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace DashboardLogistico
{
    internal static class Calculadora
    {
        internal static async Task LoadHomologacao(NotaFiscalRepository repository, Filtros filtros, Chart graficoBaixa)
        {
            graficoBaixa.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
            string queryTipoBaixa = QueryGenerator.QueryToHomologacao(filtros);

            graficoBaixa.Series.Clear();

            var dados = await repository.RunQueryAsync(queryTipoBaixa);

            if (dados.Count == 0) throw new Exception("Não retornou nenhum dado na busca");

            for (int i = 0; i < dados[filtros.Group].Count; i++)
            {

                string nomeSerie = dados[filtros.Group][i].ToString();
                string data = dados["dataInicio"][i].ToString();

                if (graficoBaixa.Series.IsUniqueName(data))
                {
                    graficoBaixa.Series.Add(data);
                    graficoBaixa.Series[data].ChartType = SeriesChartType.RangeColumn;
                    graficoBaixa.Series[data].IsValueShownAsLabel = true;
                    graficoBaixa.Series[data].IsXValueIndexed = true;

                }

                graficoBaixa.Series[data].Points.AddXY(nomeSerie, Math.Round(Convert.ToDouble(dados["Homologacao"][i]),2));

            }

            var groupUniques = dados[filtros.Group].Distinct();

            AlignGraficos(graficoBaixa, groupUniques);

        }

        internal static async Task LoadAderencia(NotaFiscalRepository repository, Filtros filtros, Chart graficoAderencia)
        {
            graficoAderencia.ChartAreas.FirstOrDefault().AxisX.Interval = 1;

            string queryTipoBaixa = QueryGenerator.QueryAderencia(filtros);

            graficoAderencia.Series.Clear();

            var dados = await repository.RunQueryAsync(queryTipoBaixa);

            if (dados.Count == 0) throw new Exception("Não retornou nenhum dado na busca");

            for (int i = 0; i < dados[filtros.Group].Count; i++)
            {

                string nomeSerie = dados[filtros.Group][i].ToString();
                string data = dados["dataInicio"][i].ToString();


                if (graficoAderencia.Series.IsUniqueName(data))
                {
                    graficoAderencia.Series.Add(data);
                    graficoAderencia.Series[data].ChartType = SeriesChartType.RangeColumn;
                    graficoAderencia.Series[data].IsValueShownAsLabel = true;
                }

                graficoAderencia.Series[data].Points.AddXY(nomeSerie, Math.Round(Convert.ToDouble(dados["Aderencia"][i]), 2));

            }

            var groupUniques = dados[filtros.Group].Distinct();
            AlignGraficos(graficoAderencia, groupUniques);
        }

        internal static async Task LoadLargada(NotaFiscalRepository repository, Filtros filtros, Chart graficoLargada)
        {
            graficoLargada.ChartAreas.FirstOrDefault().AxisX.Interval = 1;

            string queryLargadaDentro = QueryGenerator.QueryToLargada(filtros);

            graficoLargada.Series.Clear();

            var dados = await repository.RunQueryAsync(queryLargadaDentro);

            if (dados.Count == 0) throw new Exception("Não retornou nenhum dado na busca");

            for (int i = 0; i < dados[filtros.Group].Count; i++)
            {

                string nomeSerie = dados[filtros.Group][i].ToString();
                string data = dados["dataInicio"][i].ToString();

                if (graficoLargada.Series.IsUniqueName(data))
                {
                    graficoLargada.Series.Add(data);
                    graficoLargada.Series[data].ChartType = SeriesChartType.RangeColumn;
                    graficoLargada.Series[data].IsValueShownAsLabel = true;
                }

                graficoLargada.Series[data].Points.AddXY(nomeSerie, Math.Round(Convert.ToDouble(dados["Largada"][i]), 2));

            }

            var groupUniques = dados[filtros.Group].Distinct();
            AlignGraficos(graficoLargada, groupUniques);

        }

        private static void AlignGraficos(Chart grafico, IEnumerable<object> groupUniques)
        {
            var series = grafico.Series;

            foreach (var serie in series)
            {
                foreach (string groupUnique in groupUniques)
                {
                    bool existGroup = serie.Points.Select(p => p.AxisLabel).Contains(groupUnique);
                    if (!existGroup)
                    {
                        serie.Points.AddXY(groupUnique, 0);
                    }
                }
            }
        }
    }
}
