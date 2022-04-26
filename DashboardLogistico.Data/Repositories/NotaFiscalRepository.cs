using DashboardLogistico.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;

namespace DashboardLogistico.Data
{
    public class NotaFiscalRepository : INotaFiscalRepository
    {
        private ConfigGlobal _config;
        public DBConnection _dbConnection { get; internal set; }

        public NotaFiscalRepository(ConfigGlobal config, DBConnection dBConnection)
        {
            _config = config;
            _dbConnection = dBConnection;
        }

        public async Task<IEnumerable<NotaFiscal>> GetNotasAsync(Filtros filtros)
        {
            IEnumerable<NotaFiscal> notaFiscals = await _dbConnection.GetNotasAsync(filtros);

            return notaFiscals;
        }

        public async Task<IEnumerable<bool>> SaveNotasAsync(IEnumerable<NotaFiscal> notas, IProgress<NotaFiscal> reportadorDeProgresso, CancellationToken ct)
        {

            IEnumerable<string> entregas = notas.Select(n => n.Entrega).Distinct();

            //if (await _dbConnection.VerifyIfNotasExist(entregas)) throw new NotaFiscalRepositoryException("Uma ou mais Notas já existem no banco de dados");

            await _dbConnection.sqliteConnection.OpenAsync();

            var tasks = notas.Select(n => Task.Factory.StartNew(() =>
            {
                ct.ThrowIfCancellationRequested();

                _dbConnection.AddNota(n);

                reportadorDeProgresso.Report(n);

                ct.ThrowIfCancellationRequested();

                return true;
            },ct));

            return await Task.WhenAll(tasks);

        }

        public async Task<IEnumerable<NotaFiscal>> GetNotasCSVAsync(string caminho, IProgress<NotaFiscal> reportadorDeProgresso, CancellationToken ct)
        {

            IEnumerable<string> linhas = GetAllLines(caminho);

            var task = linhas.Select(linha =>
                    Task.Factory.StartNew(() =>
                    {
                        ct.ThrowIfCancellationRequested();

                        NotaFiscal nota = GetNotaByLinha(linha);

                        reportadorDeProgresso.Report(nota);

                        ct.ThrowIfCancellationRequested();

                        return nota;
                    }, ct)
                );

            return await Task.WhenAll(task);
        }

        public async Task<bool> AddUnidadedAsync(string unidade, string horaLargada)
        {
            await _dbConnection.AddUnidadeAsync(unidade, horaLargada);
            return true;
        }

        public async Task<bool> UpdateUnidadeAsync(string unidade, string horaLargada)
        {
            await _dbConnection.UpdateUnidadeAsync(unidade, horaLargada);
            return true;
        }

        public async Task<Dictionary<string, List<object>>> RunQueryAsync(string query)
        {
            return await _dbConnection.ExecuteQuery(query);
        }

        public async Task<List<Jornada>> GetJornadaAsync(string query)
        {
            return await _dbConnection.GetJornadaAsync(query);
        }

        public async Task<List<Descarga>> GetDescargaAsync(string query)
        {
            return await _dbConnection.GetDescargaAsync(query);
        }

        public async Task<IEnumerable<string>> GetFiterAsync(string query)
        {
            return await _dbConnection.GetFiterAsync(query);
        }


        private static NotaFiscal GetNotaByLinha(string linha)
        {
            string[] valores = linha.Split(';');

            NotaFiscal nota = new NotaFiscal();

            nota.CodCliente = Convert.ToString(valores[0]);
            nota.Cliente = Convert.ToString(valores[1]);
            nota.Endereco = Convert.ToString(valores[2]);
            nota.Bairro = Convert.ToString(valores[3]);
            nota.Cidade = Convert.ToString(valores[4]);
            nota.Placa = Convert.ToString(valores[5]);
            nota.Motorista = Convert.ToString(valores[6]);
            nota.Cooperativa = Convert.ToString(valores[7]);
            nota.InicioEntrega = (!string.IsNullOrEmpty(valores[8])) ? DateTime.ParseExact(valores[8], "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture) : DateTime.ParseExact("01/01/1997 00:00", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            nota.FimEntrega = (!string.IsNullOrEmpty(valores[9])) ? DateTime.ParseExact(valores[9], "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture) : DateTime.ParseExact("01/01/1997 00:00", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            nota.PesoBruto = (!string.IsNullOrEmpty(valores[10])) ? Convert.ToDouble(valores[10]) : 0;
            nota.NF = valores[11];
            nota.SeqProgramada = (!string.IsNullOrEmpty(valores[12])) ? Convert.ToInt64(valores[12]) : 0;
            nota.SeqReal = (!string.IsNullOrEmpty(valores[13])) ? Convert.ToInt64(valores[13]) : 0;
            nota.Identificador = valores[14];
            nota.CodAnomalia = valores[15];
            nota.Anomalia = valores[16];
            nota.DataAnomalia = (!string.IsNullOrEmpty(valores[17])) ? DateTime.ParseExact(valores[17], "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture) : DateTime.ParseExact("01/01/1997 00:00", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            nota.InicioViagem = (!string.IsNullOrEmpty(valores[18])) ? DateTime.ParseExact(valores[18], "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture) : DateTime.ParseExact("01/01/1997 00:00", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            nota.Unidade = valores[19];
            nota.FimViagem = (!string.IsNullOrEmpty(valores[20])) ? DateTime.ParseExact(valores[20], "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture) : DateTime.ParseExact("01/01/1997 00:00", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            nota.Baixa = valores[21];
            nota.MetrosEntrega = (!string.IsNullOrEmpty(valores[22])) ? Convert.ToDouble(valores[22]) : 0;
            nota.EntregasPrevistas = (!string.IsNullOrEmpty(valores[23])) ? Convert.ToDouble(valores[23]) : 0;
            nota.EntregasRealizadas = (!string.IsNullOrEmpty(valores[24])) ? Convert.ToDouble(valores[24]) : 0;
            nota.FimDescarregamento = (!string.IsNullOrEmpty(valores[25])) ? DateTime.ParseExact(valores[25], "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture) : DateTime.ParseExact("01/01/1997 00:00", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            nota.Valor = (!string.IsNullOrEmpty(valores[26])) ? Convert.ToDouble(valores[26]) : 0;
            nota.Latitude = (!string.IsNullOrEmpty(valores[27])) ? Convert.ToDouble(valores[27]) : 0;
            nota.Longitude = ((!string.IsNullOrEmpty(valores[28])) && (Convert.ToString(valores[28]) != ".000000")) ? Convert.ToDouble(valores[28]) : 0;
            nota.SeriePernoite = Convert.ToString(valores[29]);
            nota.StatusViagem = Convert.ToString(valores[30]);
            nota.Entrega = nota.CodCliente + "-" + nota.Identificador;
            nota.Linha = linha;
            return nota;
        }

        private IEnumerable<string> GetAllLines(string caminho)
        {
            var linhas = File.ReadLines(caminho,Encoding.UTF8);

            return linhas.Skip(1);
        }
    }
}
