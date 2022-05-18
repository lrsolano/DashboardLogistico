using DashboardLogistico.Core;
using DashboardLogistico.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace DashboardLogistico
{
    public partial class Dashboard : Form
    {

        private DBConnection dBConnection;
        private NotaFiscalRepository repositoryNota;
        private IndicadorRepository repositoryIndicador;
        private ConfigGlobal configGlobal;
        Filtros filtros;

        public Dashboard()
        {
            try
            {


                InitializeComponent();

                configGlobal = GetConfigGlobal();

                dBConnection = new DBConnection(configGlobal.CaminhoBaseDados);

                repositoryNota = new NotaFiscalRepository(configGlobal, dBConnection);

                repositoryIndicador = new IndicadorRepository(configGlobal, dBConnection);

                filtros = new Filtros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar.Visible = false;
            InitializeFilter();
        }

        private async void InitializeFilter()
        {
            filtros.Unidade = "Todos";
            filtros.Group = "Unidade";
            filtros.Cliente = "Todos";
            filtros.CodCliente = "Todos";
            filtros.Cooperativa = "Todos";

            filtros.HoraMaximaEntregaMinutos = 180;
            filtros.HoraMaximaJornadaHoras = 8;
            filtros.RaioMaximoMetros = 300;


            var datas = await repositoryNota.RunQueryAsync("SELECT MIN(InicioViagem) Menor, MAX(InicioViagem) Maior FROM Notas where InicioViagem > '2010-01-01';");

            filtros.DataInicio = Convert.ToDateTime(datas["Menor"][0]);
            filtros.DataFim = Convert.ToDateTime(datas["Maior"][0]);

            dateInicial.Value = Convert.ToDateTime(datas["Menor"][0]);
            dateFinal.Value = Convert.ToDateTime(datas["Maior"][0]);
            comboAgrupamento.Text = "Unidade";

            maximoJornada.Value = 8;
            maximoTempoDescarga.Value = 1;

            await LoadFilterAsync();

        }

        private ConfigGlobal GetConfigGlobal()
        {

            ConfigGlobal config = new ConfigGlobal();

            config.CaminhoBaseDados = @"banco.db";
            config.SenhaBanco = ConfigurationManager.AppSettings.Get("SenhaBanco");

            return config;

        }

        private void abrirUnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form loginForm = new LoginBanco(configGlobal, repositoryNota,repositoryIndicador, "unidade");

            loginForm.Show();
        }

        private void carregarCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form loginForm = new LoginBanco(configGlobal, repositoryNota, repositoryIndicador, "notas");

            loginForm.Show();
        }

        private void carregarIndicadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form loginForm = new LoginBanco(configGlobal, repositoryNota, repositoryIndicador, "indicadores");

            loginForm.Show();
        }

        private async Task LoadFilterAsync()
        {

            comboUnidade.Items.Clear();
            comboUnidade.Items.AddRange((await repositoryNota.GetFiterAsync(QueryGenerator.QueryToFilter(filtros, "Unidade"))).ToArray());
            comboUnidade.SelectedItem = "Todos";

            comboCooperativa.Items.Clear();
            comboCooperativa.Items.AddRange((await repositoryNota.GetFiterAsync(QueryGenerator.QueryToFilter(filtros, "Cooperativa"))).ToArray());
            comboCooperativa.SelectedItem = "Todos";

            comboCliente.Items.Clear();
            comboCliente.Items.AddRange((await repositoryNota.GetFiterAsync(QueryGenerator.QueryToFilter(filtros, "Cliente"))).ToArray());
            comboCliente.SelectedItem = "Todos";

            comboCodCliente.Items.Clear();
            comboCodCliente.Items.AddRange((await repositoryNota.GetFiterAsync(QueryGenerator.QueryToFilter(filtros, "CodCliente"))).ToArray());
            comboCodCliente.SelectedItem = "Todos";

            comboIdentificador.Items.Clear();
            comboIdentificador.Items.AddRange((await repositoryNota.GetFiterAsync(QueryGenerator.QueryToFilter(filtros, "Identificador"))).ToArray());
            comboIdentificador.SelectedItem = "Todos";

        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtros.Group = comboAgrupamento.Text;
            filtros.Unidade = comboUnidade.Text;
            filtros.Cooperativa = comboCooperativa.Text;
            filtros.Cliente = comboCliente.Text;
            filtros.CodCliente = comboCodCliente.Text;
            filtros.Identificador = comboIdentificador.Text;

            var dataInicio = new DateTime(dateInicial.Value.Year, dateInicial.Value.Month, dateInicial.Value.Day, 0, 0, 0);
            var dataFim = new DateTime(dateFinal.Value.Year, dateFinal.Value.Month, dateFinal.Value.Day,23, 59, 59);


            filtros.DataInicio = dataInicio;
            filtros.DataFim = dataFim;
        }

        private async void buttonFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                filter_SelectedIndexChanged(sender, e);

                string queryBaixa = QueryGenerator.QueryToHomologacao(filtros);
                await Calculadora.LoadChart(repositoryIndicador, filtros, graficoBaixa, queryBaixa);

                string queryAderencia = QueryGenerator.QueryToAderencia(filtros);
                await Calculadora.LoadChart(repositoryIndicador, filtros, graficoAderencia, queryAderencia);

                string queryLargada = QueryGenerator.QueryToLargada(filtros);
                await Calculadora.LoadChart(repositoryIndicador, filtros, graficoLargada, queryLargada);


                string query = QueryGenerator.QueryToDataIndicadores(filtros);

                List<DadoIndicador> dadosIndicadores = await repositoryIndicador.GetDadoIndicaodAsync(query);

                DadoIndicador total = new DadoIndicador();
                total.Agrupamento = "Total";
                total.Transportes = dadosIndicadores.Sum(d => d.Transportes);


                dadosIndicadores.Add(total);

                dataIndicadores.DataSource = dadosIndicadores;

                GC.Collect();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private async void buttonCarregarJornada_Click(object sender, EventArgs e)
        {
            try
            {
                string query = QueryGenerator.QueryToJornada(filtros);

                List<Jornada> dados = await repositoryNota.GetJornadaAsync(query);

                IEnumerable<DateTime> datasUnicas = dados.Select(d => DateTime.ParseExact(d.DiaViagem, "dd-MM-yyyy", null)).Distinct().OrderBy(d => d);

                SetDataJornadaHeader(datasUnicas);

                IEnumerable<string> placasUnicas = dados.Select(d => d.Placa).Distinct();

                foreach (string placa in placasUnicas)
                {
                    List<Jornada> jornadasDaPlaca = dados.FindAll(d => d.Placa == placa);

                    int row = dataJornadaTrabalho.Rows.Add();
                    dataJornadaTrabalho.Rows[row].Cells["Placa"].Value = placa;

                    foreach (Jornada jornada in jornadasDaPlaca)
                    {
                        TimeSpan timeSpan = TimeSpan.FromHours(jornada.TempoViagem);
                        if (timeSpan.TotalHours < 0) timeSpan = TimeSpan.FromHours(0);
                        dataJornadaTrabalho.Rows[row].Cells[jornada.DiaViagem].Value = timeSpan.ToString("hh\\:mm");
                        if (timeSpan.TotalHours > (double)maximoJornada.Value)
                        {
                            dataJornadaTrabalho.Rows[row].Cells[jornada.DiaViagem].Style.ForeColor = Color.Red;
                        }
                    }
                }

                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void SetDataJornadaHeader(IEnumerable<DateTime> datasUnicas)
        {

                dataJornadaTrabalho.Rows.Clear();
                dataJornadaTrabalho.Columns.Clear();

                dataJornadaTrabalho.Columns.Add("Placa", "Placa");
                foreach (DateTime data in datasUnicas)
                {
                    dataJornadaTrabalho.Columns.Add(data.ToString("dd-MM-yyyy"), data.ToString("dd-MM-yyyy"));
                }

                GC.Collect();


            
        }

        private async void buttonTempoEntrega_Click(object sender, EventArgs e)
        {
            try
            {
                string query = QueryGenerator.QueryToDescarga(filtros);

                List<Descarga> dados = await repositoryNota.GetDescargaAsync(query);

                IEnumerable<DateTime> datasUnicas = dados.Select(d => DateTime.ParseExact(d.DiaViagem, "dd-MM-yyyy", null)).Distinct().OrderBy(d => d);

                SetDataDescargaHeader(datasUnicas);

                IEnumerable<string> codClientesUnicos = dados.Select(d => d.CodCliente).Distinct();

                foreach (string codCliente in codClientesUnicos)
                {
                    List<Descarga> descargaCliente = dados.FindAll(d => d.CodCliente == codCliente && d.TempoEntrega > 0.2);

                    double avg = 0;
                    double avgInterna = 0;

                    int row = dataTempoEntrega.Rows.Add();

                    if (descargaCliente.Count > 0)
                    {
                        avg = descargaCliente.Average(d => d.TempoEntrega);
                    }

                    if(descargaCliente.Count > 3)
                    {
                        var descargaInterna = descargaCliente.OrderBy(m => m.TempoEntrega).Skip(1).Take(descargaCliente.Count - 2);
                        avgInterna = descargaInterna.Average(d => d.TempoEntrega);
                    }
                    else
                    {
                        avgInterna = avg;
                    }

                    


                    TimeSpan tempo = TimeSpan.FromHours(avg);
                    TimeSpan tempo1 = TimeSpan.FromMinutes(avg);

                    dataTempoEntrega.Rows[row].Cells["Cliente"].Value = dados.Find(d => d.CodCliente == codCliente).Cliente;
                    dataTempoEntrega.Rows[row].Cells["Cod Cliente"].Value = codCliente;
                    dataTempoEntrega.Rows[row].Cells["Media"].Value = TimeSpan.FromHours(avg).ToString(@"dd\.hh\:mm");
                    dataTempoEntrega.Rows[row].Cells["Media Interna"].Value = TimeSpan.FromHours(avgInterna).ToString(@"dd\.hh\:mm"); 

                    if (avg > (double)maximoTempoDescarga.Value)
                    {
                        dataTempoEntrega.Rows[row].Cells["Media"].Style.ForeColor = Color.Red;
                    }

                    if (avgInterna > (double)maximoTempoDescarga.Value)
                    {
                        dataTempoEntrega.Rows[row].Cells["Media Interna"].Style.ForeColor = Color.Red;
                    }

                    foreach (Descarga descarga in descargaCliente)
                    {
                        TimeSpan timeSpan = TimeSpan.FromHours(descarga.TempoEntrega);

                        dataTempoEntrega.Rows[row].Cells[descarga.DiaViagem].Value = timeSpan;

                        if (timeSpan.TotalHours > (double)maximoTempoDescarga.Value)
                        {
                            dataTempoEntrega.Rows[row].Cells[descarga.DiaViagem].Style.ForeColor = Color.Red;
                        }
                    }

                }

                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SetDataDescargaHeader(IEnumerable<DateTime> datasUnicas)
        {
            dataTempoEntrega.Columns.Clear();
            dataTempoEntrega.Columns.Clear();

            dataTempoEntrega.Columns.Add("Cod Cliente", "Cod Cliente");
            dataTempoEntrega.Columns.Add("Cliente", "Cliente");
            dataTempoEntrega.Columns.Add("Media", "Media");
            dataTempoEntrega.Columns.Add("Media Interna", "Media Interna");
            foreach (DateTime data in datasUnicas)
            {
                dataTempoEntrega.Columns.Add(data.ToString("dd-MM-yyyy"), data.ToString("dd-MM-yyyy"));
            }
        }

        private async void buttonCarregarDados_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<NotaFiscal> notas = await repositoryNota.GetNotasAsync(filtros);

                dataDados.DataSource = notas;

                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void exportaDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string mensagem = "Salvar Arquivo Dados Filtrados";
                DataGridView dataGridView = dataDados;
                ExportData(mensagem, dataGridView);

                GC.Collect();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void exportaJornadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string mensagem = "Salvar Arquivo Jornada";
                DataGridView dataGridView = dataJornadaTrabalho;
                ExportData(mensagem, dataGridView);

                GC.Collect();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void exportaTempoEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string mensagem = "Salvar Arquivo Tempo de Entrega";
                DataGridView dataGridView = dataTempoEntrega;
                ExportData(mensagem, dataGridView);

                GC.Collect();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void exportaIndicadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string mensagem = "Salvar Arquivo Indicadores";
                DataGridView dataGridView = dataIndicadores;
                ExportData(mensagem, dataGridView);

                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportData(string mensagem, DataGridView dataGridView)
        {
            //define o titulo
            saveDados.Title = mensagem;
            //Define as extensões permitidas
            saveDados.Filter = "CSV File|.csv";
            //define o indice do filtro
            saveDados.FilterIndex = 0;
            //Atribui um valor vazio ao nome do arquivo
            saveDados.FileName = "Export_" + DateTime.Now.ToString("ddMMyyyy_HHmmss");
            //Define a extensão padrão como .txt
            saveDados.DefaultExt = ".csv";
            //define o diretório padrão
            saveDados.InitialDirectory = @"c:\temp";
            //restaura o diretorio atual antes de fechar a janela
            saveDados.RestoreDirectory = true;

            //Abre a caixa de dialogo e determina qual botão foi pressionado
            DialogResult resultado = saveDados.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //Cria um stream usando o nome do arquivo
                FileStream fs = new FileStream(saveDados.FileName, FileMode.Create);

                //Cria um escrito que irá escrever no stream
                StreamWriter writer = new StreamWriter(fs);
                //escreve o conteúdo da caixa de texto no stream
                string cabecalho = "";
                for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
                {
                    cabecalho += dataGridView.Columns[i - 1].HeaderText + ";";
                }
                writer.WriteLine(cabecalho);
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    string linha = "";
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        linha += Convert.ToString(dataGridView.Rows[i].Cells[j].Value) + ";";
                    }
                    writer.WriteLine(linha);
                }

                //fecha o escrito e o stream
                writer.Close();

                writer.Dispose();

                fs.Dispose();

                GC.Collect();

                MessageBox.Show("Documento Criado");
            }
            else
            {
                //exibe mensagem informando que a operação foi cancelada
                MessageBox.Show("Operação cancelada");
            }

            GC.Collect();

        }

    }
}
