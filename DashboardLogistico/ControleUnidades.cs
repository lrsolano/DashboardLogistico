using DashboardLogistico.Core;
using DashboardLogistico.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardLogistico
{
    public partial class ControleUnidades : Form
    {
        private ConfigGlobal _config;
        private NotaFiscalRepository _repository;

        public ControleUnidades(ConfigGlobal config, NotaFiscalRepository notaFiscalRepository)
        {
            _config = config;
            _repository = notaFiscalRepository;

            InitializeComponent();
        }

        private async void buttonAtualizarUnidade_Click(object sender, EventArgs e)
        {
            try
            {
                string unidade = comboBoxUnidades.Text;

                string horaLargada = textBoxHoraLargada.Text;

                await _repository.UpdateUnidadeAsync(unidade, horaLargada);

                MessageBox.Show($"{unidade} atualizada com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private async void ControleUnidades_Load(object sender, EventArgs e)
        {
            var unidades = await _repository.RunQueryAsync($@"SELECT Unidade FROM Unidades");

            if (unidades.Count > 0)
            {
                comboBoxUnidades.Items.AddRange(unidades["Unidade"].ToArray());
                comboBoxUnidades.SelectedIndex = 0;
            }


            
        }

        private void ControleUnidades_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Owner.Close();
        }

        private async void comboBoxUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            string unidade = comboBoxUnidades.Text;

            var busca = await _repository.RunQueryAsync($@"SELECT HoraLargada FROM Unidades WHERE Unidade = '{unidade}'");

            textBoxHoraLargada.Text = busca["HoraLargada"].First().ToString();
        }

        private async void buttonAdicionarUnidade_Click(object sender, EventArgs e)
        {
            try
            {
                string unidade = textBoxNovaUnidade.Text;

                string horaLargada = textBoxNovaHora.Text;

                if(string.IsNullOrEmpty(unidade) || string.IsNullOrEmpty(horaLargada)) throw new ArgumentNullException("Informe os dois campos");

                var unidades = await _repository.RunQueryAsync($@"SELECT Unidade FROM Unidades");

                if (unidades.ContainsKey("Unidade"))
                {
                    if (unidades["Unidade"].Contains(unidade)) throw new ArgumentException("Unidade já está cadastrada"); 
                }


                await _repository.AddUnidadedAsync(unidade, horaLargada);

                MessageBox.Show($"{unidade} atualizada com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
