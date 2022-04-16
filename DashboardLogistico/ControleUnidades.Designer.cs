
namespace DashboardLogistico
{
    partial class ControleUnidades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleUnidades));
            this.comboBoxUnidades = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAtualizarUnidade = new System.Windows.Forms.Button();
            this.textBoxHoraLargada = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdicionarUnidade = new System.Windows.Forms.Button();
            this.textBoxNovaHora = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNovaUnidade = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxUnidades
            // 
            this.comboBoxUnidades.FormattingEnabled = true;
            this.comboBoxUnidades.Location = new System.Drawing.Point(6, 33);
            this.comboBoxUnidades.Name = "comboBoxUnidades";
            this.comboBoxUnidades.Size = new System.Drawing.Size(136, 21);
            this.comboBoxUnidades.TabIndex = 0;
            this.comboBoxUnidades.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnidades_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAtualizarUnidade);
            this.groupBox1.Controls.Add(this.textBoxHoraLargada);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxUnidades);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unidades";
            // 
            // buttonAtualizarUnidade
            // 
            this.buttonAtualizarUnidade.Location = new System.Drawing.Point(398, 22);
            this.buttonAtualizarUnidade.Name = "buttonAtualizarUnidade";
            this.buttonAtualizarUnidade.Size = new System.Drawing.Size(141, 23);
            this.buttonAtualizarUnidade.TabIndex = 3;
            this.buttonAtualizarUnidade.Text = "Atualizar";
            this.buttonAtualizarUnidade.UseVisualStyleBackColor = true;
            this.buttonAtualizarUnidade.Click += new System.EventHandler(this.buttonAtualizarUnidade_Click);
            // 
            // textBoxHoraLargada
            // 
            this.textBoxHoraLargada.Location = new System.Drawing.Point(278, 25);
            this.textBoxHoraLargada.Mask = "00:00";
            this.textBoxHoraLargada.Name = "textBoxHoraLargada";
            this.textBoxHoraLargada.Size = new System.Drawing.Size(100, 20);
            this.textBoxHoraLargada.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hora de Largada";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonAdicionarUnidade);
            this.groupBox2.Controls.Add(this.textBoxNovaHora);
            this.groupBox2.Controls.Add(this.textBoxNovaUnidade);
            this.groupBox2.Location = new System.Drawing.Point(18, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 59);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adicionar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hora de Largada";
            // 
            // buttonAdicionarUnidade
            // 
            this.buttonAdicionarUnidade.Location = new System.Drawing.Point(392, 30);
            this.buttonAdicionarUnidade.Name = "buttonAdicionarUnidade";
            this.buttonAdicionarUnidade.Size = new System.Drawing.Size(135, 23);
            this.buttonAdicionarUnidade.TabIndex = 2;
            this.buttonAdicionarUnidade.Text = "Adicionar";
            this.buttonAdicionarUnidade.UseVisualStyleBackColor = true;
            this.buttonAdicionarUnidade.Click += new System.EventHandler(this.buttonAdicionarUnidade_Click);
            // 
            // textBoxNovaHora
            // 
            this.textBoxNovaHora.Location = new System.Drawing.Point(272, 32);
            this.textBoxNovaHora.Mask = "00:00";
            this.textBoxNovaHora.Name = "textBoxNovaHora";
            this.textBoxNovaHora.Size = new System.Drawing.Size(100, 20);
            this.textBoxNovaHora.TabIndex = 1;
            // 
            // textBoxNovaUnidade
            // 
            this.textBoxNovaUnidade.Location = new System.Drawing.Point(6, 32);
            this.textBoxNovaUnidade.Name = "textBoxNovaUnidade";
            this.textBoxNovaUnidade.Size = new System.Drawing.Size(130, 20);
            this.textBoxNovaUnidade.TabIndex = 0;
            // 
            // ControleUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 240);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControleUnidades";
            this.Text = "Unidades";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ControleUnidades_FormClosed);
            this.Load += new System.EventHandler(this.ControleUnidades_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUnidades;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox textBoxHoraLargada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAtualizarUnidade;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox textBoxNovaHora;
        private System.Windows.Forms.TextBox textBoxNovaUnidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdicionarUnidade;
    }
}