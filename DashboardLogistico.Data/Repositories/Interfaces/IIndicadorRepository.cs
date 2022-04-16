using DashboardLogistico.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DashboardLogistico.Data
{
    public interface IIndicadorRepository
    {
        Task<IEnumerable<bool>> SaveIndicadoresAsync(IEnumerable<Indicador> indicadores, IProgress<Indicador> reportadorDeProgresso, CancellationToken ct);
        Task<IEnumerable<Indicador>> GetIndicadoresCSVAsync(string caminho, IProgress<Indicador> reportadorDeProgresso, CancellationToken ct);
        Task<Dictionary<string, List<object>>> RunQueryAsync(string query);
        Task<List<DadoIndicador>> GetDadoIndicaodAsync(string query);
    }
}
