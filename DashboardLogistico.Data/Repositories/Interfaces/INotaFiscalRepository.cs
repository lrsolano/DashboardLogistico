using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DashboardLogistico.Core;

namespace DashboardLogistico.Data
{
    public interface INotaFiscalRepository
    {
        Task<IEnumerable<NotaFiscal>> GetNotasAsync(Filtros filtros);
        Task<IEnumerable<bool>> SaveNotasAsync(IEnumerable<NotaFiscal> notas, IProgress<NotaFiscal> reportadorDeProgresso, CancellationToken ct);
        Task<IEnumerable<NotaFiscal>> GetNotasCSVAsync(string caminho, IProgress<NotaFiscal> reportadorDeProgresso, CancellationToken ct);
        Task<Dictionary<string, List<object>>> RunQueryAsync(string query);
        Task<IEnumerable<string>> GetFiterAsync(string query);
        Task<List<Jornada>> GetJornadaAsync(string query);
        Task<List<Descarga>> GetDescargaAsync(string query);

    }
}
