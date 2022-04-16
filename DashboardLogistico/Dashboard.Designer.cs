
namespace DashboardLogistico
{
    partial class Dashboard
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button buttonFiltrar;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportaDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportaJornadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportaTempoEntregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportaIndicadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirUnidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarIndicadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoBaixa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFiltros = new System.Windows.Forms.TabPage();
            this.graficoLargada = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graficoAderencia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.comboIdentificador = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboCodCliente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboCooperativa = new System.Windows.Forms.ComboBox();
            this.comboUnidade = new System.Windows.Forms.ComboBox();
            this.comboAgrupamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabJornada = new System.Windows.Forms.TabPage();
            this.buttonCarregarJornada = new System.Windows.Forms.Button();
            this.dataJornadaTrabalho = new System.Windows.Forms.DataGridView();
            this.tabTempoEntrega = new System.Windows.Forms.TabPage();
            this.buttonTempoEntrega = new System.Windows.Forms.Button();
            this.dataTempoEntrega = new System.Windows.Forms.DataGridView();
            this.dataIndicadores = new System.Windows.Forms.DataGridView();
            this.dadoIndicadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabDados = new System.Windows.Forms.TabPage();
            this.buttonCarregarDados = new System.Windows.Forms.Button();
            this.dataDados = new System.Windows.Forms.DataGridView();
            this.codClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motoristaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cooperativaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioEntregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fimEntregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoBrutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seqProgramadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seqRealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codAnomaliaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anomaliaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAnomaliaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioViagemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fimViagemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baixaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metrosEntregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entregasPrevistasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entregasRealizadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fimDescarregamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriePernoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusViagemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaFiscalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabParametros = new System.Windows.Forms.TabPage();
            this.maximoTempoDescarga = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.maximoJornada = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.saveDados = new System.Windows.Forms.SaveFileDialog();
            this.agrupamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homologacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aderenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.largadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            buttonFiltrar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoBaixa)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoLargada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoAderencia)).BeginInit();
            this.tabJornada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataJornadaTrabalho)).BeginInit();
            this.tabTempoEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTempoEntrega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataIndicadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadoIndicadorBindingSource)).BeginInit();
            this.tabDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaFiscalBindingSource)).BeginInit();
            this.tabParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximoTempoDescarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximoJornada)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFiltrar
            // 
            buttonFiltrar.Location = new System.Drawing.Point(1306, 6);
            buttonFiltrar.Name = "buttonFiltrar";
            buttonFiltrar.Size = new System.Drawing.Size(126, 21);
            buttonFiltrar.TabIndex = 17;
            buttonFiltrar.Text = "Filtrar";
            buttonFiltrar.UseVisualStyleBackColor = true;
            buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 739);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1460, 10);
            this.progressBar.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.configuraçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportaDadosToolStripMenuItem,
            this.exportaJornadaToolStripMenuItem,
            this.exportaTempoEntregaToolStripMenuItem,
            this.exportaIndicadoresToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exportaDadosToolStripMenuItem
            // 
            this.exportaDadosToolStripMenuItem.Name = "exportaDadosToolStripMenuItem";
            this.exportaDadosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exportaDadosToolStripMenuItem.Text = "Exporta Dados";
            this.exportaDadosToolStripMenuItem.Click += new System.EventHandler(this.exportaDadosToolStripMenuItem_Click);
            // 
            // exportaJornadaToolStripMenuItem
            // 
            this.exportaJornadaToolStripMenuItem.Name = "exportaJornadaToolStripMenuItem";
            this.exportaJornadaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exportaJornadaToolStripMenuItem.Text = "Exporta Jornada";
            this.exportaJornadaToolStripMenuItem.Click += new System.EventHandler(this.exportaJornadaToolStripMenuItem_Click);
            // 
            // exportaTempoEntregaToolStripMenuItem
            // 
            this.exportaTempoEntregaToolStripMenuItem.Name = "exportaTempoEntregaToolStripMenuItem";
            this.exportaTempoEntregaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exportaTempoEntregaToolStripMenuItem.Text = "Exporta Tempo Entrega";
            this.exportaTempoEntregaToolStripMenuItem.Click += new System.EventHandler(this.exportaTempoEntregaToolStripMenuItem_Click);
            // 
            // exportaIndicadoresToolStripMenuItem
            // 
            this.exportaIndicadoresToolStripMenuItem.Name = "exportaIndicadoresToolStripMenuItem";
            this.exportaIndicadoresToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exportaIndicadoresToolStripMenuItem.Text = "Exporta Indicadores";
            this.exportaIndicadoresToolStripMenuItem.Click += new System.EventHandler(this.exportaIndicadoresToolStripMenuItem_Click);
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirUnidadesToolStripMenuItem,
            this.carregarCSVToolStripMenuItem,
            this.carregarIndicadoresToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            // 
            // abrirUnidadesToolStripMenuItem
            // 
            this.abrirUnidadesToolStripMenuItem.Name = "abrirUnidadesToolStripMenuItem";
            this.abrirUnidadesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.abrirUnidadesToolStripMenuItem.Text = "Abrir Unidades";
            this.abrirUnidadesToolStripMenuItem.Click += new System.EventHandler(this.abrirUnidadesToolStripMenuItem_Click);
            // 
            // carregarCSVToolStripMenuItem
            // 
            this.carregarCSVToolStripMenuItem.Name = "carregarCSVToolStripMenuItem";
            this.carregarCSVToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.carregarCSVToolStripMenuItem.Text = "Carregar Notas";
            this.carregarCSVToolStripMenuItem.Click += new System.EventHandler(this.carregarCSVToolStripMenuItem_Click);
            // 
            // carregarIndicadoresToolStripMenuItem
            // 
            this.carregarIndicadoresToolStripMenuItem.Name = "carregarIndicadoresToolStripMenuItem";
            this.carregarIndicadoresToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.carregarIndicadoresToolStripMenuItem.Text = "Carregar Indicadores";
            this.carregarIndicadoresToolStripMenuItem.Click += new System.EventHandler(this.carregarIndicadoresToolStripMenuItem_Click);
            // 
            // graficoBaixa
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsMarksNextToAxis = false;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep90) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.graficoBaixa.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficoBaixa.Legends.Add(legend1);
            this.graficoBaixa.Location = new System.Drawing.Point(10, 71);
            this.graficoBaixa.Name = "graficoBaixa";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graficoBaixa.Series.Add(series1);
            this.graficoBaixa.Size = new System.Drawing.Size(1021, 211);
            this.graficoBaixa.TabIndex = 2;
            this.graficoBaixa.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title1.Name = "Title1";
            title1.Text = "Cargas Monitoradas";
            this.graficoBaixa.Titles.Add(title1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFiltros);
            this.tabControl1.Controls.Add(this.tabJornada);
            this.tabControl1.Controls.Add(this.tabTempoEntrega);
            this.tabControl1.Controls.Add(this.tabDados);
            this.tabControl1.Controls.Add(this.tabParametros);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1484, 822);
            this.tabControl1.TabIndex = 3;
            // 
            // tabFiltros
            // 
            this.tabFiltros.Controls.Add(this.dataIndicadores);
            this.tabFiltros.Controls.Add(this.graficoLargada);
            this.tabFiltros.Controls.Add(this.graficoAderencia);
            this.tabFiltros.Controls.Add(this.graficoBaixa);
            this.tabFiltros.Controls.Add(buttonFiltrar);
            this.tabFiltros.Controls.Add(this.dateFinal);
            this.tabFiltros.Controls.Add(this.label8);
            this.tabFiltros.Controls.Add(this.dateInicial);
            this.tabFiltros.Controls.Add(this.label7);
            this.tabFiltros.Controls.Add(this.comboIdentificador);
            this.tabFiltros.Controls.Add(this.label6);
            this.tabFiltros.Controls.Add(this.comboCodCliente);
            this.tabFiltros.Controls.Add(this.label5);
            this.tabFiltros.Controls.Add(this.comboCliente);
            this.tabFiltros.Controls.Add(this.label4);
            this.tabFiltros.Controls.Add(this.comboCooperativa);
            this.tabFiltros.Controls.Add(this.comboUnidade);
            this.tabFiltros.Controls.Add(this.comboAgrupamento);
            this.tabFiltros.Controls.Add(this.label3);
            this.tabFiltros.Controls.Add(this.label2);
            this.tabFiltros.Controls.Add(this.label1);
            this.tabFiltros.Location = new System.Drawing.Point(4, 22);
            this.tabFiltros.Name = "tabFiltros";
            this.tabFiltros.Padding = new System.Windows.Forms.Padding(3);
            this.tabFiltros.Size = new System.Drawing.Size(1476, 796);
            this.tabFiltros.TabIndex = 0;
            this.tabFiltros.Text = "Principal";
            this.tabFiltros.UseVisualStyleBackColor = true;
            // 
            // graficoLargada
            // 
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.graficoLargada.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graficoLargada.Legends.Add(legend2);
            this.graficoLargada.Location = new System.Drawing.Point(10, 278);
            this.graficoLargada.Name = "graficoLargada";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.graficoLargada.Series.Add(series2);
            this.graficoLargada.Size = new System.Drawing.Size(1021, 211);
            this.graficoLargada.TabIndex = 19;
            this.graficoLargada.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title2.Name = "Title1";
            title2.Text = "Largada";
            this.graficoLargada.Titles.Add(title2);
            // 
            // graficoAderencia
            // 
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineWidth = 0;
            chartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.Name = "ChartArea1";
            this.graficoAderencia.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.graficoAderencia.Legends.Add(legend3);
            this.graficoAderencia.Location = new System.Drawing.Point(10, 504);
            this.graficoAderencia.Name = "graficoAderencia";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.graficoAderencia.Series.Add(series3);
            this.graficoAderencia.Size = new System.Drawing.Size(1021, 211);
            this.graficoAderencia.TabIndex = 18;
            this.graficoAderencia.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title3.Name = "Title1";
            title3.Text = "Raio de Entrega";
            this.graficoAderencia.Titles.Add(title3);
            // 
            // dateFinal
            // 
            this.dateFinal.Location = new System.Drawing.Point(417, 45);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(200, 20);
            this.dateFinal.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Data Final:";
            // 
            // dateInicial
            // 
            this.dateInicial.Location = new System.Drawing.Point(81, 44);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(200, 20);
            this.dateInicial.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data Inicial:";
            // 
            // comboIdentificador
            // 
            this.comboIdentificador.FormattingEnabled = true;
            this.comboIdentificador.Location = new System.Drawing.Point(1135, 6);
            this.comboIdentificador.Name = "comboIdentificador";
            this.comboIdentificador.Size = new System.Drawing.Size(121, 21);
            this.comboIdentificador.TabIndex = 12;
            this.comboIdentificador.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1061, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Identificador:";
            // 
            // comboCodCliente
            // 
            this.comboCodCliente.FormattingEnabled = true;
            this.comboCodCliente.Location = new System.Drawing.Point(910, 6);
            this.comboCodCliente.Name = "comboCodCliente";
            this.comboCodCliente.Size = new System.Drawing.Size(121, 21);
            this.comboCodCliente.TabIndex = 10;
            this.comboCodCliente.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(843, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CodCliente:";
            // 
            // comboCliente
            // 
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(701, 6);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(121, 21);
            this.comboCliente.TabIndex = 8;
            this.comboCliente.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cliente:";
            // 
            // comboCooperativa
            // 
            this.comboCooperativa.FormattingEnabled = true;
            this.comboCooperativa.Location = new System.Drawing.Point(504, 6);
            this.comboCooperativa.Name = "comboCooperativa";
            this.comboCooperativa.Size = new System.Drawing.Size(121, 21);
            this.comboCooperativa.TabIndex = 6;
            this.comboCooperativa.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
            // 
            // comboUnidade
            // 
            this.comboUnidade.FormattingEnabled = true;
            this.comboUnidade.Location = new System.Drawing.Point(287, 6);
            this.comboUnidade.Name = "comboUnidade";
            this.comboUnidade.Size = new System.Drawing.Size(121, 21);
            this.comboUnidade.TabIndex = 5;
            this.comboUnidade.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
            // 
            // comboAgrupamento
            // 
            this.comboAgrupamento.FormattingEnabled = true;
            this.comboAgrupamento.Items.AddRange(new object[] {
            "Unidade",
            "Cooperativa",
            "Regional"});
            this.comboAgrupamento.Location = new System.Drawing.Point(88, 6);
            this.comboAgrupamento.Name = "comboAgrupamento";
            this.comboAgrupamento.Size = new System.Drawing.Size(121, 21);
            this.comboAgrupamento.TabIndex = 4;
            this.comboAgrupamento.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cooperativa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agrupamento:";
            // 
            // tabJornada
            // 
            this.tabJornada.Controls.Add(this.buttonCarregarJornada);
            this.tabJornada.Controls.Add(this.dataJornadaTrabalho);
            this.tabJornada.Location = new System.Drawing.Point(4, 22);
            this.tabJornada.Name = "tabJornada";
            this.tabJornada.Padding = new System.Windows.Forms.Padding(3);
            this.tabJornada.Size = new System.Drawing.Size(1476, 796);
            this.tabJornada.TabIndex = 1;
            this.tabJornada.Text = "Jornada de Trabalho";
            this.tabJornada.UseVisualStyleBackColor = true;
            // 
            // buttonCarregarJornada
            // 
            this.buttonCarregarJornada.Location = new System.Drawing.Point(614, 6);
            this.buttonCarregarJornada.Name = "buttonCarregarJornada";
            this.buttonCarregarJornada.Size = new System.Drawing.Size(183, 23);
            this.buttonCarregarJornada.TabIndex = 1;
            this.buttonCarregarJornada.Text = "Carregar Jornada";
            this.buttonCarregarJornada.UseVisualStyleBackColor = true;
            this.buttonCarregarJornada.Click += new System.EventHandler(this.buttonCarregarJornada_Click);
            // 
            // dataJornadaTrabalho
            // 
            this.dataJornadaTrabalho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataJornadaTrabalho.Location = new System.Drawing.Point(-4, 35);
            this.dataJornadaTrabalho.Name = "dataJornadaTrabalho";
            this.dataJornadaTrabalho.Size = new System.Drawing.Size(1480, 765);
            this.dataJornadaTrabalho.TabIndex = 0;
            // 
            // tabTempoEntrega
            // 
            this.tabTempoEntrega.Controls.Add(this.buttonTempoEntrega);
            this.tabTempoEntrega.Controls.Add(this.dataTempoEntrega);
            this.tabTempoEntrega.Location = new System.Drawing.Point(4, 22);
            this.tabTempoEntrega.Name = "tabTempoEntrega";
            this.tabTempoEntrega.Size = new System.Drawing.Size(1476, 796);
            this.tabTempoEntrega.TabIndex = 3;
            this.tabTempoEntrega.Text = "Tempo de Entrega";
            this.tabTempoEntrega.UseVisualStyleBackColor = true;
            // 
            // buttonTempoEntrega
            // 
            this.buttonTempoEntrega.Location = new System.Drawing.Point(623, 6);
            this.buttonTempoEntrega.Name = "buttonTempoEntrega";
            this.buttonTempoEntrega.Size = new System.Drawing.Size(183, 23);
            this.buttonTempoEntrega.TabIndex = 2;
            this.buttonTempoEntrega.Text = "Carregar Tempo Entrega";
            this.buttonTempoEntrega.UseVisualStyleBackColor = true;
            this.buttonTempoEntrega.Click += new System.EventHandler(this.buttonTempoEntrega_Click);
            // 
            // dataTempoEntrega
            // 
            this.dataTempoEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTempoEntrega.Location = new System.Drawing.Point(-4, 35);
            this.dataTempoEntrega.Name = "dataTempoEntrega";
            this.dataTempoEntrega.Size = new System.Drawing.Size(1480, 765);
            this.dataTempoEntrega.TabIndex = 1;
            // 
            // dataIndicadores
            // 
            this.dataIndicadores.AutoGenerateColumns = false;
            this.dataIndicadores.BackgroundColor = System.Drawing.Color.White;
            this.dataIndicadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataIndicadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agrupamentoDataGridViewTextBoxColumn,
            this.transportesDataGridViewTextBoxColumn,
            this.homologacaoDataGridViewTextBoxColumn,
            this.aderenciaDataGridViewTextBoxColumn,
            this.largadaDataGridViewTextBoxColumn});
            this.dataIndicadores.DataSource = this.dadoIndicadorBindingSource;
            this.dataIndicadores.Location = new System.Drawing.Point(994, 71);
            this.dataIndicadores.Name = "dataIndicadores";
            this.dataIndicadores.Size = new System.Drawing.Size(474, 629);
            this.dataIndicadores.TabIndex = 0;
            // 
            // dadoIndicadorBindingSource
            // 
            this.dadoIndicadorBindingSource.DataSource = typeof(DashboardLogistico.Core.DadoIndicador);
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.buttonCarregarDados);
            this.tabDados.Controls.Add(this.dataDados);
            this.tabDados.Location = new System.Drawing.Point(4, 22);
            this.tabDados.Name = "tabDados";
            this.tabDados.Size = new System.Drawing.Size(1476, 796);
            this.tabDados.TabIndex = 4;
            this.tabDados.Text = "Dados";
            this.tabDados.UseVisualStyleBackColor = true;
            // 
            // buttonCarregarDados
            // 
            this.buttonCarregarDados.Location = new System.Drawing.Point(625, 1);
            this.buttonCarregarDados.Name = "buttonCarregarDados";
            this.buttonCarregarDados.Size = new System.Drawing.Size(183, 23);
            this.buttonCarregarDados.TabIndex = 4;
            this.buttonCarregarDados.Text = "Carregar Dados";
            this.buttonCarregarDados.UseVisualStyleBackColor = true;
            this.buttonCarregarDados.Click += new System.EventHandler(this.buttonCarregarDados_Click);
            // 
            // dataDados
            // 
            this.dataDados.AutoGenerateColumns = false;
            this.dataDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codClienteDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.motoristaDataGridViewTextBoxColumn,
            this.cooperativaDataGridViewTextBoxColumn,
            this.inicioEntregaDataGridViewTextBoxColumn,
            this.fimEntregaDataGridViewTextBoxColumn,
            this.pesoBrutoDataGridViewTextBoxColumn,
            this.nFDataGridViewTextBoxColumn,
            this.seqProgramadaDataGridViewTextBoxColumn,
            this.seqRealDataGridViewTextBoxColumn,
            this.identificadorDataGridViewTextBoxColumn,
            this.codAnomaliaDataGridViewTextBoxColumn,
            this.anomaliaDataGridViewTextBoxColumn,
            this.dataAnomaliaDataGridViewTextBoxColumn,
            this.inicioViagemDataGridViewTextBoxColumn,
            this.unidadeDataGridViewTextBoxColumn,
            this.fimViagemDataGridViewTextBoxColumn,
            this.baixaDataGridViewTextBoxColumn,
            this.metrosEntregaDataGridViewTextBoxColumn,
            this.entregasPrevistasDataGridViewTextBoxColumn,
            this.entregasRealizadasDataGridViewTextBoxColumn,
            this.fimDescarregamentoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.latitudeDataGridViewTextBoxColumn,
            this.longitudeDataGridViewTextBoxColumn,
            this.seriePernoiteDataGridViewTextBoxColumn,
            this.statusViagemDataGridViewTextBoxColumn});
            this.dataDados.DataSource = this.notaFiscalBindingSource;
            this.dataDados.Location = new System.Drawing.Point(-2, 30);
            this.dataDados.Name = "dataDados";
            this.dataDados.Size = new System.Drawing.Size(1480, 765);
            this.dataDados.TabIndex = 3;
            // 
            // codClienteDataGridViewTextBoxColumn
            // 
            this.codClienteDataGridViewTextBoxColumn.DataPropertyName = "CodCliente";
            this.codClienteDataGridViewTextBoxColumn.HeaderText = "CodCliente";
            this.codClienteDataGridViewTextBoxColumn.Name = "codClienteDataGridViewTextBoxColumn";
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            // 
            // motoristaDataGridViewTextBoxColumn
            // 
            this.motoristaDataGridViewTextBoxColumn.DataPropertyName = "Motorista";
            this.motoristaDataGridViewTextBoxColumn.HeaderText = "Motorista";
            this.motoristaDataGridViewTextBoxColumn.Name = "motoristaDataGridViewTextBoxColumn";
            // 
            // cooperativaDataGridViewTextBoxColumn
            // 
            this.cooperativaDataGridViewTextBoxColumn.DataPropertyName = "Cooperativa";
            this.cooperativaDataGridViewTextBoxColumn.HeaderText = "Cooperativa";
            this.cooperativaDataGridViewTextBoxColumn.Name = "cooperativaDataGridViewTextBoxColumn";
            // 
            // inicioEntregaDataGridViewTextBoxColumn
            // 
            this.inicioEntregaDataGridViewTextBoxColumn.DataPropertyName = "InicioEntrega";
            this.inicioEntregaDataGridViewTextBoxColumn.HeaderText = "InicioEntrega";
            this.inicioEntregaDataGridViewTextBoxColumn.Name = "inicioEntregaDataGridViewTextBoxColumn";
            // 
            // fimEntregaDataGridViewTextBoxColumn
            // 
            this.fimEntregaDataGridViewTextBoxColumn.DataPropertyName = "FimEntrega";
            this.fimEntregaDataGridViewTextBoxColumn.HeaderText = "FimEntrega";
            this.fimEntregaDataGridViewTextBoxColumn.Name = "fimEntregaDataGridViewTextBoxColumn";
            // 
            // pesoBrutoDataGridViewTextBoxColumn
            // 
            this.pesoBrutoDataGridViewTextBoxColumn.DataPropertyName = "PesoBruto";
            this.pesoBrutoDataGridViewTextBoxColumn.HeaderText = "PesoBruto";
            this.pesoBrutoDataGridViewTextBoxColumn.Name = "pesoBrutoDataGridViewTextBoxColumn";
            // 
            // nFDataGridViewTextBoxColumn
            // 
            this.nFDataGridViewTextBoxColumn.DataPropertyName = "NF";
            this.nFDataGridViewTextBoxColumn.HeaderText = "NF";
            this.nFDataGridViewTextBoxColumn.Name = "nFDataGridViewTextBoxColumn";
            // 
            // seqProgramadaDataGridViewTextBoxColumn
            // 
            this.seqProgramadaDataGridViewTextBoxColumn.DataPropertyName = "SeqProgramada";
            this.seqProgramadaDataGridViewTextBoxColumn.HeaderText = "SeqProgramada";
            this.seqProgramadaDataGridViewTextBoxColumn.Name = "seqProgramadaDataGridViewTextBoxColumn";
            // 
            // seqRealDataGridViewTextBoxColumn
            // 
            this.seqRealDataGridViewTextBoxColumn.DataPropertyName = "SeqReal";
            this.seqRealDataGridViewTextBoxColumn.HeaderText = "SeqReal";
            this.seqRealDataGridViewTextBoxColumn.Name = "seqRealDataGridViewTextBoxColumn";
            // 
            // identificadorDataGridViewTextBoxColumn
            // 
            this.identificadorDataGridViewTextBoxColumn.DataPropertyName = "Identificador";
            this.identificadorDataGridViewTextBoxColumn.HeaderText = "Identificador";
            this.identificadorDataGridViewTextBoxColumn.Name = "identificadorDataGridViewTextBoxColumn";
            // 
            // codAnomaliaDataGridViewTextBoxColumn
            // 
            this.codAnomaliaDataGridViewTextBoxColumn.DataPropertyName = "CodAnomalia";
            this.codAnomaliaDataGridViewTextBoxColumn.HeaderText = "CodAnomalia";
            this.codAnomaliaDataGridViewTextBoxColumn.Name = "codAnomaliaDataGridViewTextBoxColumn";
            // 
            // anomaliaDataGridViewTextBoxColumn
            // 
            this.anomaliaDataGridViewTextBoxColumn.DataPropertyName = "Anomalia";
            this.anomaliaDataGridViewTextBoxColumn.HeaderText = "Anomalia";
            this.anomaliaDataGridViewTextBoxColumn.Name = "anomaliaDataGridViewTextBoxColumn";
            // 
            // dataAnomaliaDataGridViewTextBoxColumn
            // 
            this.dataAnomaliaDataGridViewTextBoxColumn.DataPropertyName = "DataAnomalia";
            this.dataAnomaliaDataGridViewTextBoxColumn.HeaderText = "DataAnomalia";
            this.dataAnomaliaDataGridViewTextBoxColumn.Name = "dataAnomaliaDataGridViewTextBoxColumn";
            // 
            // inicioViagemDataGridViewTextBoxColumn
            // 
            this.inicioViagemDataGridViewTextBoxColumn.DataPropertyName = "InicioViagem";
            this.inicioViagemDataGridViewTextBoxColumn.HeaderText = "InicioViagem";
            this.inicioViagemDataGridViewTextBoxColumn.Name = "inicioViagemDataGridViewTextBoxColumn";
            // 
            // unidadeDataGridViewTextBoxColumn
            // 
            this.unidadeDataGridViewTextBoxColumn.DataPropertyName = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.HeaderText = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.Name = "unidadeDataGridViewTextBoxColumn";
            // 
            // fimViagemDataGridViewTextBoxColumn
            // 
            this.fimViagemDataGridViewTextBoxColumn.DataPropertyName = "FimViagem";
            this.fimViagemDataGridViewTextBoxColumn.HeaderText = "FimViagem";
            this.fimViagemDataGridViewTextBoxColumn.Name = "fimViagemDataGridViewTextBoxColumn";
            // 
            // baixaDataGridViewTextBoxColumn
            // 
            this.baixaDataGridViewTextBoxColumn.DataPropertyName = "Baixa";
            this.baixaDataGridViewTextBoxColumn.HeaderText = "Baixa";
            this.baixaDataGridViewTextBoxColumn.Name = "baixaDataGridViewTextBoxColumn";
            // 
            // metrosEntregaDataGridViewTextBoxColumn
            // 
            this.metrosEntregaDataGridViewTextBoxColumn.DataPropertyName = "MetrosEntrega";
            this.metrosEntregaDataGridViewTextBoxColumn.HeaderText = "MetrosEntrega";
            this.metrosEntregaDataGridViewTextBoxColumn.Name = "metrosEntregaDataGridViewTextBoxColumn";
            // 
            // entregasPrevistasDataGridViewTextBoxColumn
            // 
            this.entregasPrevistasDataGridViewTextBoxColumn.DataPropertyName = "EntregasPrevistas";
            this.entregasPrevistasDataGridViewTextBoxColumn.HeaderText = "EntregasPrevistas";
            this.entregasPrevistasDataGridViewTextBoxColumn.Name = "entregasPrevistasDataGridViewTextBoxColumn";
            // 
            // entregasRealizadasDataGridViewTextBoxColumn
            // 
            this.entregasRealizadasDataGridViewTextBoxColumn.DataPropertyName = "EntregasRealizadas";
            this.entregasRealizadasDataGridViewTextBoxColumn.HeaderText = "EntregasRealizadas";
            this.entregasRealizadasDataGridViewTextBoxColumn.Name = "entregasRealizadasDataGridViewTextBoxColumn";
            // 
            // fimDescarregamentoDataGridViewTextBoxColumn
            // 
            this.fimDescarregamentoDataGridViewTextBoxColumn.DataPropertyName = "FimDescarregamento";
            this.fimDescarregamentoDataGridViewTextBoxColumn.HeaderText = "FimDescarregamento";
            this.fimDescarregamentoDataGridViewTextBoxColumn.Name = "fimDescarregamentoDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // latitudeDataGridViewTextBoxColumn
            // 
            this.latitudeDataGridViewTextBoxColumn.DataPropertyName = "Latitude";
            this.latitudeDataGridViewTextBoxColumn.HeaderText = "Latitude";
            this.latitudeDataGridViewTextBoxColumn.Name = "latitudeDataGridViewTextBoxColumn";
            // 
            // longitudeDataGridViewTextBoxColumn
            // 
            this.longitudeDataGridViewTextBoxColumn.DataPropertyName = "Longitude";
            this.longitudeDataGridViewTextBoxColumn.HeaderText = "Longitude";
            this.longitudeDataGridViewTextBoxColumn.Name = "longitudeDataGridViewTextBoxColumn";
            // 
            // seriePernoiteDataGridViewTextBoxColumn
            // 
            this.seriePernoiteDataGridViewTextBoxColumn.DataPropertyName = "SeriePernoite";
            this.seriePernoiteDataGridViewTextBoxColumn.HeaderText = "SeriePernoite";
            this.seriePernoiteDataGridViewTextBoxColumn.Name = "seriePernoiteDataGridViewTextBoxColumn";
            // 
            // statusViagemDataGridViewTextBoxColumn
            // 
            this.statusViagemDataGridViewTextBoxColumn.DataPropertyName = "StatusViagem";
            this.statusViagemDataGridViewTextBoxColumn.HeaderText = "StatusViagem";
            this.statusViagemDataGridViewTextBoxColumn.Name = "statusViagemDataGridViewTextBoxColumn";
            // 
            // notaFiscalBindingSource
            // 
            this.notaFiscalBindingSource.DataSource = typeof(DashboardLogistico.Core.NotaFiscal);
            // 
            // tabParametros
            // 
            this.tabParametros.Controls.Add(this.maximoTempoDescarga);
            this.tabParametros.Controls.Add(this.label10);
            this.tabParametros.Controls.Add(this.maximoJornada);
            this.tabParametros.Controls.Add(this.label9);
            this.tabParametros.Location = new System.Drawing.Point(4, 22);
            this.tabParametros.Name = "tabParametros";
            this.tabParametros.Size = new System.Drawing.Size(1476, 796);
            this.tabParametros.TabIndex = 2;
            this.tabParametros.Text = "Parametros";
            this.tabParametros.UseVisualStyleBackColor = true;
            // 
            // maximoTempoDescarga
            // 
            this.maximoTempoDescarga.DecimalPlaces = 1;
            this.maximoTempoDescarga.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.maximoTempoDescarga.Location = new System.Drawing.Point(176, 59);
            this.maximoTempoDescarga.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.maximoTempoDescarga.Name = "maximoTempoDescarga";
            this.maximoTempoDescarga.Size = new System.Drawing.Size(120, 20);
            this.maximoTempoDescarga.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tempo Máximo Entrega Horas:";
            // 
            // maximoJornada
            // 
            this.maximoJornada.DecimalPlaces = 1;
            this.maximoJornada.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.maximoJornada.Location = new System.Drawing.Point(176, 19);
            this.maximoJornada.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.maximoJornada.Name = "maximoJornada";
            this.maximoJornada.Size = new System.Drawing.Size(120, 20);
            this.maximoJornada.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Hora Máxima Jornada Horas:";
            // 
            // agrupamentoDataGridViewTextBoxColumn
            // 
            this.agrupamentoDataGridViewTextBoxColumn.DataPropertyName = "Agrupamento";
            this.agrupamentoDataGridViewTextBoxColumn.HeaderText = "Agrupamento";
            this.agrupamentoDataGridViewTextBoxColumn.Name = "agrupamentoDataGridViewTextBoxColumn";
            this.agrupamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transportesDataGridViewTextBoxColumn
            // 
            this.transportesDataGridViewTextBoxColumn.DataPropertyName = "Transportes";
            this.transportesDataGridViewTextBoxColumn.HeaderText = "Transportes";
            this.transportesDataGridViewTextBoxColumn.Name = "transportesDataGridViewTextBoxColumn";
            this.transportesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homologacaoDataGridViewTextBoxColumn
            // 
            this.homologacaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.homologacaoDataGridViewTextBoxColumn.DataPropertyName = "Homologacao";
            this.homologacaoDataGridViewTextBoxColumn.HeaderText = "Homologacao";
            this.homologacaoDataGridViewTextBoxColumn.Name = "homologacaoDataGridViewTextBoxColumn";
            this.homologacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aderenciaDataGridViewTextBoxColumn
            // 
            this.aderenciaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aderenciaDataGridViewTextBoxColumn.DataPropertyName = "Aderencia";
            this.aderenciaDataGridViewTextBoxColumn.HeaderText = "Aderencia";
            this.aderenciaDataGridViewTextBoxColumn.Name = "aderenciaDataGridViewTextBoxColumn";
            this.aderenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // largadaDataGridViewTextBoxColumn
            // 
            this.largadaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.largadaDataGridViewTextBoxColumn.DataPropertyName = "Largada";
            this.largadaDataGridViewTextBoxColumn.HeaderText = "Largada";
            this.largadaDataGridViewTextBoxColumn.Name = "largadaDataGridViewTextBoxColumn";
            this.largadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Logistico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoBaixa)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabFiltros.ResumeLayout(false);
            this.tabFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoLargada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoAderencia)).EndInit();
            this.tabJornada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataJornadaTrabalho)).EndInit();
            this.tabTempoEntrega.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTempoEntrega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataIndicadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadoIndicadorBindingSource)).EndInit();
            this.tabDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaFiscalBindingSource)).EndInit();
            this.tabParametros.ResumeLayout(false);
            this.tabParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximoTempoDescarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximoJornada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirUnidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carregarCSVToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoBaixa;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFiltros;
        private System.Windows.Forms.TabPage tabJornada;
        private System.Windows.Forms.TabPage tabParametros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboAgrupamento;
        private System.Windows.Forms.ComboBox comboUnidade;
        private System.Windows.Forms.ComboBox comboCooperativa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboCodCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.ComboBox comboIdentificador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoLargada;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoAderencia;
        private System.Windows.Forms.Button buttonCarregarJornada;
        private System.Windows.Forms.DataGridView dataJornadaTrabalho;
        private System.Windows.Forms.NumericUpDown maximoJornada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabTempoEntrega;
        private System.Windows.Forms.Button buttonTempoEntrega;
        private System.Windows.Forms.DataGridView dataTempoEntrega;
        private System.Windows.Forms.NumericUpDown maximoTempoDescarga;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabDados;
        private System.Windows.Forms.Button buttonCarregarDados;
        private System.Windows.Forms.DataGridView dataDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn codClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motoristaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cooperativaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioEntregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fimEntregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoBrutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seqProgramadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seqRealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAnomaliaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anomaliaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAnomaliaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioViagemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fimViagemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baixaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metrosEntregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entregasPrevistasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entregasRealizadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fimDescarregamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriePernoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusViagemDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource notaFiscalBindingSource;
        private System.Windows.Forms.ToolStripMenuItem carregarIndicadoresToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataIndicadores;
        private System.Windows.Forms.BindingSource dadoIndicadorBindingSource;
        private System.Windows.Forms.ToolStripMenuItem exportaDadosToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveDados;
        private System.Windows.Forms.ToolStripMenuItem exportaJornadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportaTempoEntregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportaIndicadoresToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn agrupamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homologacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aderenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn largadaDataGridViewTextBoxColumn;
    }
}

