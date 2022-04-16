using DashboardLogistico.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DashboardLogistico.Data
{
    public class IndicadorRepository : IIndicadorRepository
    {
        private ConfigGlobal _config;
        public DBConnection _dbConnection { get; internal set; }

        public IndicadorRepository(ConfigGlobal config, DBConnection dBConnection)
        {
            _config = config;
            _dbConnection = dBConnection;
        }

        public async Task<IEnumerable<bool>> SaveIndicadoresAsync(IEnumerable<Indicador> indicadores, IProgress<Indicador> reportadorDeProgresso, CancellationToken ct)
        {

            IEnumerable<string> entregas = indicadores.Select(n => n.Identificador).Distinct();

            if (await _dbConnection.VerifyIfIndicadorExist(entregas)) throw new NotaFiscalRepositoryException("Uma ou mais indicadores já existem no banco de dados");

            await _dbConnection.sqliteConnection.OpenAsync();

            var tasks = indicadores.Select(n => Task.Factory.StartNew(() =>
            {
                ct.ThrowIfCancellationRequested();

                _dbConnection.AddIndicador(n);

                reportadorDeProgresso.Report(n);

                ct.ThrowIfCancellationRequested();

                return true;
            }, ct));

            return await Task.WhenAll(tasks);
        }

        public async Task<IEnumerable<Indicador>> GetIndicadoresCSVAsync(string caminho, IProgress<Indicador> reportadorDeProgresso, CancellationToken ct)
        {
            IEnumerable<string> linhas = GetAllLines(caminho);

            var task = linhas.Select(linha =>
                    Task.Factory.StartNew(() =>
                    {
                        ct.ThrowIfCancellationRequested();

                        Indicador indicador = GetIndicadorByLinha(linha);

                        reportadorDeProgresso.Report(indicador);

                        ct.ThrowIfCancellationRequested();

                        return indicador;
                    }, ct)
                );

            return await Task.WhenAll(task);
        }

        public Task<Dictionary<string, List<object>>> RunQueryAsync(string query)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<string> GetAllLines(string caminho)
        {
            var linhas = File.ReadLines(caminho, Encoding.UTF8);

            return linhas.Skip(1);
        }
        public async Task<List<DadoIndicador>> GetDadoIndicaodAsync(string query)
        {
            return await _dbConnection.GetDadoIndicaodAsync(query);
        }

        private static Indicador GetIndicadorByLinha(string linha)
        {
            string[] valores = linha.Split(';');

            Indicador indicador = new Indicador();

            indicador.Regional = Convert.ToString(valores[0]);
            indicador.Unidade = Convert.ToString(valores[1]);
            indicador.Data = (!string.IsNullOrEmpty(valores[2])) ? DateTime.ParseExact(valores[2], "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture) : DateTime.ParseExact("01/01/1997 00:00", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            indicador.Identificador = Convert.ToString(valores[3]);
            indicador.Placa = Convert.ToString(valores[5]);
            indicador.Cooperativa = Convert.ToString(valores[6]);
            indicador.Aderencia = (!string.IsNullOrEmpty(valores[7])) ? Convert.ToDouble(valores[7]) : 0;
            indicador.Largada = (valores[10] == "Sim") ? 100 : 0;
            indicador.Homologacao = (!string.IsNullOrEmpty(valores[12])) ? Convert.ToDouble(valores[12]) : 0;
            indicador.Linha = linha;

            return indicador;
        }
    }
}
