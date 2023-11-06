namespace apRedeDeTrens
{
    partial class FrmMapeamentoCidades
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMapeamentoCidades));
            this.udCoordenadaY = new System.Windows.Forms.NumericUpDown();
            this.udCoordenadaX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCidade = new System.Windows.Forms.TextBox();
            this.stMensagem = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbMapeamento = new System.Windows.Forms.TabControl();
            this.tpCidades = new System.Windows.Forms.TabPage();
            this.gbCaminhos = new System.Windows.Forms.GroupBox();
            this.btnEditarCaminhos = new System.Windows.Forms.Button();
            this.btnExcluirCaminho = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.udTempo = new System.Windows.Forms.NumericUpDown();
            this.udDistancia = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbOrigem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCidades = new System.Windows.Forms.GroupBox();
            this.dgvCaminhos = new System.Windows.Forms.DataGridView();
            this.columnDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDistancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnProcurar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.pbMapa = new System.Windows.Forms.PictureBox();
            this.tpArvore = new System.Windows.Forms.TabPage();
            this.pbArvore = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dlgCidades = new System.Windows.Forms.OpenFileDialog();
            this.dlgCaminhos = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.udCoordenadaY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCoordenadaX)).BeginInit();
            this.stMensagem.SuspendLayout();
            this.tbMapeamento.SuspendLayout();
            this.tpCidades.SuspendLayout();
            this.gbCaminhos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDistancia)).BeginInit();
            this.gbCidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).BeginInit();
            this.tpArvore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArvore)).BeginInit();
            this.SuspendLayout();
            // 
            // udCoordenadaY
            // 
            this.udCoordenadaY.DecimalPlaces = 3;
            this.udCoordenadaY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.udCoordenadaY.Location = new System.Drawing.Point(134, 90);
            this.udCoordenadaY.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.udCoordenadaY.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udCoordenadaY.Name = "udCoordenadaY";
            this.udCoordenadaY.Size = new System.Drawing.Size(166, 26);
            this.udCoordenadaY.TabIndex = 8;
            // 
            // udCoordenadaX
            // 
            this.udCoordenadaX.DecimalPlaces = 3;
            this.udCoordenadaX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.udCoordenadaX.Location = new System.Drawing.Point(134, 53);
            this.udCoordenadaX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.udCoordenadaX.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udCoordenadaX.Name = "udCoordenadaX";
            this.udCoordenadaX.Size = new System.Drawing.Size(166, 26);
            this.udCoordenadaX.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Coordenada Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Coordenada X: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome da cidade:";
            // 
            // txtNomeCidade
            // 
            this.txtNomeCidade.Location = new System.Drawing.Point(134, 19);
            this.txtNomeCidade.Name = "txtNomeCidade";
            this.txtNomeCidade.Size = new System.Drawing.Size(166, 26);
            this.txtNomeCidade.TabIndex = 1;
            // 
            // stMensagem
            // 
            this.stMensagem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.stMensagem.Location = new System.Drawing.Point(0, 712);
            this.stMensagem.Name = "stMensagem";
            this.stMensagem.Size = new System.Drawing.Size(1073, 22);
            this.stMensagem.TabIndex = 6;
            this.stMensagem.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel1.Text = "Registro 1/23";
            // 
            // tbMapeamento
            // 
            this.tbMapeamento.Controls.Add(this.tpCidades);
            this.tbMapeamento.Controls.Add(this.tpArvore);
            this.tbMapeamento.Location = new System.Drawing.Point(12, 12);
            this.tbMapeamento.Name = "tbMapeamento";
            this.tbMapeamento.SelectedIndex = 0;
            this.tbMapeamento.Size = new System.Drawing.Size(1127, 660);
            this.tbMapeamento.TabIndex = 7;
            // 
            // tpCidades
            // 
            this.tpCidades.Controls.Add(this.gbCaminhos);
            this.tpCidades.Controls.Add(this.gbCidades);
            this.tpCidades.Controls.Add(this.toolStrip1);
            this.tpCidades.Controls.Add(this.pbMapa);
            this.tpCidades.Location = new System.Drawing.Point(4, 27);
            this.tpCidades.Name = "tpCidades";
            this.tpCidades.Padding = new System.Windows.Forms.Padding(3);
            this.tpCidades.Size = new System.Drawing.Size(1119, 629);
            this.tpCidades.TabIndex = 0;
            this.tpCidades.Text = "Caminhos";
            this.tpCidades.UseVisualStyleBackColor = true;
            this.tpCidades.Enter += new System.EventHandler(this.tpCidades_Enter);
            // 
            // gbCaminhos
            // 
            this.gbCaminhos.Controls.Add(this.btnEditarCaminhos);
            this.gbCaminhos.Controls.Add(this.btnExcluirCaminho);
            this.gbCaminhos.Controls.Add(this.btnAdicionar);
            this.gbCaminhos.Controls.Add(this.udTempo);
            this.gbCaminhos.Controls.Add(this.udDistancia);
            this.gbCaminhos.Controls.Add(this.label7);
            this.gbCaminhos.Controls.Add(this.label6);
            this.gbCaminhos.Controls.Add(this.cbDestino);
            this.gbCaminhos.Controls.Add(this.label5);
            this.gbCaminhos.Controls.Add(this.cbOrigem);
            this.gbCaminhos.Controls.Add(this.label1);
            this.gbCaminhos.Location = new System.Drawing.Point(6, 420);
            this.gbCaminhos.Name = "gbCaminhos";
            this.gbCaminhos.Size = new System.Drawing.Size(328, 220);
            this.gbCaminhos.TabIndex = 12;
            this.gbCaminhos.TabStop = false;
            this.gbCaminhos.Text = "Caminhos";
            // 
            // btnEditarCaminhos
            // 
            this.btnEditarCaminhos.Location = new System.Drawing.Point(272, 173);
            this.btnEditarCaminhos.Name = "btnEditarCaminhos";
            this.btnEditarCaminhos.Size = new System.Drawing.Size(47, 23);
            this.btnEditarCaminhos.TabIndex = 15;
            this.btnEditarCaminhos.Text = "#";
            this.btnEditarCaminhos.UseVisualStyleBackColor = true;
            this.btnEditarCaminhos.Click += new System.EventHandler(this.btnEditarCaminhos_Click);
            // 
            // btnExcluirCaminho
            // 
            this.btnExcluirCaminho.Location = new System.Drawing.Point(272, 137);
            this.btnExcluirCaminho.Name = "btnExcluirCaminho";
            this.btnExcluirCaminho.Size = new System.Drawing.Size(47, 23);
            this.btnExcluirCaminho.TabIndex = 14;
            this.btnExcluirCaminho.Text = "-";
            this.btnExcluirCaminho.UseVisualStyleBackColor = true;
            this.btnExcluirCaminho.Click += new System.EventHandler(this.btnExcluirCaminho_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(272, 99);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(47, 23);
            this.btnAdicionar.TabIndex = 13;
            this.btnAdicionar.Text = "+";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // udTempo
            // 
            this.udTempo.Location = new System.Drawing.Point(98, 134);
            this.udTempo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.udTempo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.udTempo.Name = "udTempo";
            this.udTempo.Size = new System.Drawing.Size(99, 26);
            this.udTempo.TabIndex = 11;
            // 
            // udDistancia
            // 
            this.udDistancia.Location = new System.Drawing.Point(98, 96);
            this.udDistancia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.udDistancia.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.udDistancia.Name = "udDistancia";
            this.udDistancia.Size = new System.Drawing.Size(99, 26);
            this.udDistancia.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tempo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Distância: ";
            // 
            // cbDestino
            // 
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(145, 54);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(121, 26);
            this.cbDestino.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Destino:";
            // 
            // cbOrigem
            // 
            this.cbOrigem.FormattingEnabled = true;
            this.cbOrigem.Location = new System.Drawing.Point(9, 54);
            this.cbOrigem.Name = "cbOrigem";
            this.cbOrigem.Size = new System.Drawing.Size(121, 26);
            this.cbOrigem.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origem:";
            // 
            // gbCidades
            // 
            this.gbCidades.Controls.Add(this.label2);
            this.gbCidades.Controls.Add(this.dgvCaminhos);
            this.gbCidades.Controls.Add(this.txtNomeCidade);
            this.gbCidades.Controls.Add(this.label3);
            this.gbCidades.Controls.Add(this.udCoordenadaY);
            this.gbCidades.Controls.Add(this.udCoordenadaX);
            this.gbCidades.Controls.Add(this.label4);
            this.gbCidades.Location = new System.Drawing.Point(6, 59);
            this.gbCidades.Name = "gbCidades";
            this.gbCidades.Size = new System.Drawing.Size(328, 345);
            this.gbCidades.TabIndex = 11;
            this.gbCidades.TabStop = false;
            this.gbCidades.Text = "Cidades";
            // 
            // dgvCaminhos
            // 
            this.dgvCaminhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaminhos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDestino,
            this.columnDistancia,
            this.columnTempo});
            this.dgvCaminhos.Location = new System.Drawing.Point(5, 122);
            this.dgvCaminhos.Name = "dgvCaminhos";
            this.dgvCaminhos.ReadOnly = true;
            this.dgvCaminhos.RowTemplate.Height = 25;
            this.dgvCaminhos.Size = new System.Drawing.Size(295, 209);
            this.dgvCaminhos.TabIndex = 10;
            this.dgvCaminhos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCaminhos_RowHeaderMouseClick);
            // 
            // columnDestino
            // 
            this.columnDestino.HeaderText = "destino";
            this.columnDestino.Name = "columnDestino";
            this.columnDestino.ReadOnly = true;
            // 
            // columnDistancia
            // 
            this.columnDistancia.HeaderText = "distância";
            this.columnDistancia.Name = "columnDistancia";
            this.columnDistancia.ReadOnly = true;
            this.columnDistancia.Width = 75;
            // 
            // columnTempo
            // 
            this.columnTempo.HeaderText = "tempo";
            this.columnTempo.Name = "columnTempo";
            this.columnTempo.ReadOnly = true;
            this.columnTempo.Width = 65;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProcurar,
            this.toolStripSeparator1,
            this.btnNovo,
            this.btnCancelar,
            this.btnSalvar,
            this.toolStripSeparator4,
            this.btnEditar,
            this.toolStripSeparator2,
            this.btnExcluir,
            this.toolStripSeparator3,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1113, 53);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip2";
            // 
            // btnProcurar
            // 
            this.btnProcurar.AutoSize = false;
            this.btnProcurar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurar.Image")));
            this.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProcurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(50, 50);
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProcurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 53);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = false;
            this.btnNovo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(50, 50);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = false;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(50, 50);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 53);
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = false;
            this.btnEditar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 53);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = false;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(50, 50);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 53);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = false;
            this.btnSair.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 50);
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pbMapa
            // 
            this.pbMapa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMapa.Image = ((System.Drawing.Image)(resources.GetObject("pbMapa.Image")));
            this.pbMapa.Location = new System.Drawing.Point(340, 59);
            this.pbMapa.Name = "pbMapa";
            this.pbMapa.Size = new System.Drawing.Size(716, 504);
            this.pbMapa.TabIndex = 5;
            this.pbMapa.TabStop = false;
            this.pbMapa.Click += new System.EventHandler(this.pbMapa_Click);
            this.pbMapa.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMapaPaint);
            // 
            // tpArvore
            // 
            this.tpArvore.Controls.Add(this.pbArvore);
            this.tpArvore.Location = new System.Drawing.Point(4, 27);
            this.tpArvore.Name = "tpArvore";
            this.tpArvore.Padding = new System.Windows.Forms.Padding(3);
            this.tpArvore.Size = new System.Drawing.Size(1119, 629);
            this.tpArvore.TabIndex = 1;
            this.tpArvore.Text = "Árvore";
            this.tpArvore.UseVisualStyleBackColor = true;
            this.tpArvore.Enter += new System.EventHandler(this.tpCaminhos_Enter);
            // 
            // pbArvore
            // 
            this.pbArvore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbArvore.Location = new System.Drawing.Point(6, 6);
            this.pbArvore.Name = "pbArvore";
            this.pbArvore.Size = new System.Drawing.Size(1010, 549);
            this.pbArvore.TabIndex = 0;
            this.pbArvore.TabStop = false;
            this.pbArvore.Paint += new System.Windows.Forms.PaintEventHandler(this.pbArvore_Paint);
            // 
            // dlgCidades
            // 
            this.dlgCidades.FileName = "openFileDialog1";
            // 
            // dlgCaminhos
            // 
            this.dlgCaminhos.FileName = "openFileDialog1";
            // 
            // FrmMapeamentoCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 734);
            this.Controls.Add(this.tbMapeamento);
            this.Controls.Add(this.stMensagem);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMapeamentoCidades";
            this.Text = "Mapeamento de Cidades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMapeamentoCidades_FormClosing);
            this.Load += new System.EventHandler(this.FrmMapeamentoCidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udCoordenadaY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCoordenadaX)).EndInit();
            this.stMensagem.ResumeLayout(false);
            this.stMensagem.PerformLayout();
            this.tbMapeamento.ResumeLayout(false);
            this.tpCidades.ResumeLayout(false);
            this.tpCidades.PerformLayout();
            this.gbCaminhos.ResumeLayout(false);
            this.gbCaminhos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDistancia)).EndInit();
            this.gbCidades.ResumeLayout(false);
            this.gbCidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).EndInit();
            this.tpArvore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbArvore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtNomeCidade;
        private Label label2;
        private NumericUpDown udCoordenadaY;
        private NumericUpDown udCoordenadaX;
        private Label label4;
        private Label label3;
        private StatusStrip stMensagem;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TabControl tbMapeamento;
        private TabPage tpCidades;
        private TabPage tpArvore;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private OpenFileDialog dlgCidades;
        private OpenFileDialog dlgCaminhos;
        private PictureBox pbMapa;
        private ToolStrip toolStrip1;
        private ToolStripButton btnProcurar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNovo;
        private ToolStripButton btnCancelar;
        private ToolStripButton btnSalvar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnSair;
        private ToolStripButton btnEditar;
        private ToolStripSeparator toolStripSeparator4;
        private GroupBox gbCaminhos;
        private GroupBox gbCidades;
        private DataGridView dgvCaminhos;
        private Label label1;
        private ComboBox cbOrigem;
        private ComboBox cbDestino;
        private Label label5;
        private Label label7;
        private Label label6;
        private NumericUpDown udTempo;
        private NumericUpDown udDistancia;
        private Button btnEditarCaminhos;
        private Button btnExcluirCaminho;
        private Button btnAdicionar;
        private PictureBox pbArvore;
        private DataGridViewTextBoxColumn columnDestino;
        private DataGridViewTextBoxColumn columnDistancia;
        private DataGridViewTextBoxColumn columnTempo;
    }
}