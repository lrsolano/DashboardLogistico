using DashboardLogistico.Core;
using DashboardLogistico.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardLogistico
{
    public partial class LoginBanco : Form
    {
        private ConfigGlobal _configGlobal;
        private NotaFiscalRepository _repositoryNota;
        private IndicadorRepository _repositoryIndicador;
        private string Contexto { get; set; }

        public LoginBanco(ConfigGlobal configGlobal, NotaFiscalRepository repositoryNota, IndicadorRepository repositoryIndicador, string contexto)
        {
            _configGlobal = configGlobal;
            _repositoryNota = repositoryNota;
            _repositoryIndicador = repositoryIndicador;
            Contexto = contexto;
            
            InitializeComponent();

            progressBarCSV.Visible = false;
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string senhaDigitada = textBoxSenha.Text;

                string senhaDigitada64 = Utils.EncodeToBase64(senhaDigitada);

                if (senhaDigitada64 != _configGlobal.SenhaBanco) throw new ArgumentException("Senha incorreta");

                if(Contexto == "unidade")
                {
                    Form controleUnidades = new ControleUnidades(_configGlobal, _repositoryNota);

                    controleUnidades.Show();

                    this.Hide();
                }
                else if(Contexto == "notas")
                {
                    this.openCSVNotas.Multiselect = false;
                    this.openCSVNotas.Title = "Selecionar Arquivo Monitor de Entregas";
                    openCSVNotas.Filter = "CSV Files|*.csv";

                    DialogResult dr = openCSVNotas.ShowDialog();

                    if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(openCSVNotas.FileName))
                    {

                        string caminhoNotas = openCSVNotas.FileName;
                        progressBarCSV.Visible = true;
                        await AdicionarNotasBancoAsync(caminhoNotas);
                        progressBarCSV.Visible = false;
                        this.Close();
                    }
                }
                else if (Contexto == "indicadores")
                {
                    this.openCSVNotas.Multiselect = false;
                    this.openCSVNotas.Title = "Selecionar Arquivo Monitor de Entregas";
                    openCSVNotas.Filter = "CSV Files|*.csv";

                    DialogResult dr = openCSVNotas.ShowDialog();

                    if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(openCSVNotas.FileName))
                    {

                        string caminho = openCSVNotas.FileName;
                        progressBarCSV.Visible = true;
                        await AdicionarIndicadoresBancoAsync(caminho);
                        progressBarCSV.Visible = false;
                        this.Close();
                    }
                }

                GC.Collect();

            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBarCSV.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBarCSV.Visible = false;
            }

        }

        private async Task AdicionarNotasBancoAsync(string caminho)
        {
            

            IProgress<NotaFiscal> progress = new Progress<NotaFiscal>();

            var novasNotas = await _repositoryNota.GetNotasCSVAsync(caminho, progress, CancellationToken.None);

            progressBarCSV.Maximum = novasNotas.Count();

            progress = new Progress<NotaFiscal>(n => { progressBarCSV.Value++; });

            await _repositoryNota.SaveNotasAsync(novasNotas, progress, CancellationToken.None);

            _repositoryNota._dbConnection.CloseConnection();

            MessageBox.Show("Carregamento Finalizado \n Total de Notas carregadas: " + novasNotas.Count(), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            GC.Collect();

        }

        private async Task AdicionarIndicadoresBancoAsync(string caminho)
        {


            IProgress<Indicador> progress = new Progress<Indicador>();

            var novosIndicadores = await _repositoryIndicador.GetIndicadoresCSVAsync(caminho, progress, CancellationToken.None);

            progressBarCSV.Maximum = novosIndicadores.Count();

            progress = new Progress<Indicador>(n => { progressBarCSV.Value++; });

            await _repositoryIndicador.SaveIndicadoresAsync(novosIndicadores, progress, CancellationToken.None);

            _repositoryIndicador._dbConnection.CloseConnection();

            MessageBox.Show("Carregamento Finalizado \n Total de Indicadores carregados: " + novosIndicadores.Count(), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            GC.Collect();

        }

        private void LoginBanco_Load(object sender, EventArgs e)
        {

        }
    }
}
