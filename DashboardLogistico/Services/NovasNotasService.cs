using DashboardLogistico.Core;
using DashboardLogistico.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardLogistico.Services
{
    internal static class NovasNotasService
    {

        internal static async Task AdicionarNovasCaixas(IEnumerable<NotaFiscal> notas,NotaFiscalRepository notaFiscalRepository,DBConnection dBConnection, ProgressBar progress, CancellationToken ct)
        {
            progress.Maximum = notas.Count();

            IProgress<NotaFiscal> progressSave = new Progress<NotaFiscal>(x => progress.Value++);

            await notaFiscalRepository.SaveNotasAsync(notas, progressSave, CancellationToken.None);

            dBConnection.CloseConnection();
        }

        internal static async Task<IEnumerable<NotaFiscal>> GetNewNotas(string caminhoCsv, ConfigGlobal configGlobal, DBConnection dBConnection)
        {
            IProgress<NotaFiscal> progress = new Progress<NotaFiscal>();

            NotaFiscalRepository notaFiscalRepository = new NotaFiscalRepository(configGlobal, dBConnection);

            IEnumerable<NotaFiscal> notas = await notaFiscalRepository.GetNotasCSVAsync(caminhoCsv, progress, CancellationToken.None);

            return notas;
        }

    }
}
