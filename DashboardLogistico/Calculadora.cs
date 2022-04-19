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
        internal static async Task LoadChart(IndicadorRepository repository, Filtros filtros, Chart chart, string query)
        {
         

            chart.Series.Clear();

            List<DTOChart> dados = await repository.GetIndicadordAsync(query);

            //if (dados.Count == 0) throw new Exception("Não retornou nenhum dado na busca");

            AlignGraficos(ref dados);

            List<string> datas = dados.Select(x => x.MesAno).Distinct().ToList();
            List<string> agrupamentos = dados.Select(x => x.Agrupamento).Distinct().ToList();

            foreach (string data in datas)
            {
                var pontos = dados.FindAll(d => d.MesAno == data);
                chart.Series.Add(data);
                chart.Series[data].ChartType = SeriesChartType.RangeColumn;
                chart.Series[data].IsValueShownAsLabel = true;

                foreach (string agrupamento in agrupamentos)
                {
                    DTOChart item = dados.Find(d => d.Agrupamento == agrupamento && d.MesAno == data);

                    chart.Series[data].Points.AddXY(item.Agrupamento, item.Valor);
                }

                
            }

            /*foreach (DTOChart item in dados)
            {
                if (chart.Series.IsUniqueName(item.MesAno))
                {
                    chart.Series.Add(item.MesAno);
                    chart.Series[item.MesAno].ChartType = SeriesChartType.RangeColumn;
                    chart.Series[item.MesAno].IsValueShownAsLabel = true;
                    chart.Series[item.MesAno].Points.DataBindXY(x, y);
                    chart.Series[item.MesAno].IsXValueIndexed = true;

                }

                chart.Series[item.MesAno].Points.AddXY(item.Agrupamento, Math.Round(item.Valor, 2));
            }*/


            //chart.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
        }

        private static void AlignGraficos(ref List<DTOChart> dados)
        {
            List<string> datas = dados.Select(x => x.MesAno).Distinct().ToList();

            List<string> agrupamentos = dados.Select(x => x.Agrupamento).Distinct().ToList();

            foreach(string data in datas)
            {
                foreach(string agrupamento in agrupamentos)
                {
                    if(dados.Find(d => d.Agrupamento == agrupamento && d.MesAno == data) == null)
                    {
                        DTOChart dado = new DTOChart { Agrupamento = agrupamento, MesAno = data, Valor = 0 };

                        dados.Add(dado);
                    }
                }
            }

        }

       
    }
}
