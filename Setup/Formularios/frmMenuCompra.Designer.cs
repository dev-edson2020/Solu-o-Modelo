namespace Setup.Formularios
{
    partial class frmMenuCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuCompra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btAlterar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtDashBoard = new System.Windows.Forms.ToolStripButton();
            this.BtProduto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtPessoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BtRelatorio = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBuscas = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSomaGeral = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNCompraCancelada = new System.Windows.Forms.Label();
            this.lblNCompraNormal = new System.Windows.Forms.Label();
            this.lblNComprasGeral = new System.Windows.Forms.Label();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ckCancelado = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDashBoard = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dgListaCompra = new Setup.Controles.dg();
            this.COMPRA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORNECEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FINALIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SITUACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_NOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CADASTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDataFinal = new Setup.Controles.txtDataLeave();
            this.txtDataInicial = new Setup.Controles.txtDataLeave();
            this.cbProduto = new Setup.Controles.cbCombo();
            this.cbFornecedor = new Setup.Controles.cbCombo();
            this.txtNumNota = new Setup.Controles.txtNumero();
            this.txtCEP1 = new Setup.Controles.txtCEP();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBuscas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaCompra)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtNovo,
            this.toolStripSeparator1,
            this.btAlterar,
            this.toolStripSeparator2,
            this.BtBuscar,
            this.toolStripSeparator3,
            this.BtDashBoard,
            this.BtProduto,
            this.toolStripSeparator4,
            this.BtPessoa,
            this.toolStripSeparator5,
            this.BtRelatorio});
            this.toolStrip1.Location = new System.Drawing.Point(-2, 52);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.toolStrip1.Size = new System.Drawing.Size(1162, 156);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtNovo
            // 
            this.BtNovo.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtNovo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BtNovo.Image = ((System.Drawing.Image)(resources.GetObject("BtNovo.Image")));
            this.BtNovo.ImageTransparentColor = System.Drawing.Color.Maroon;
            this.BtNovo.Name = "BtNovo";
            this.BtNovo.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.BtNovo.Size = new System.Drawing.Size(148, 113);
            this.BtNovo.Text = "Nova Compra";
            this.BtNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtNovo.Click += new System.EventHandler(this.BtNovo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 116);
            // 
            // btAlterar
            // 
            this.btAlterar.Font = new System.Drawing.Font("Consolas", 9F);
            this.btAlterar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btAlterar.Image")));
            this.btAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.btAlterar.Size = new System.Drawing.Size(169, 113);
            this.btAlterar.Text = "Alterar Compra";
            this.btAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 116);
            // 
            // BtBuscar
            // 
            this.BtBuscar.Enabled = false;
            this.BtBuscar.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtBuscar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BtBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtBuscar.Image")));
            this.BtBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.BtBuscar.Size = new System.Drawing.Size(134, 113);
            this.BtBuscar.Text = "Pesquisar";
            this.BtBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 116);
            // 
            // BtDashBoard
            // 
            this.BtDashBoard.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtDashBoard.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BtDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("BtDashBoard.Image")));
            this.BtDashBoard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtDashBoard.Name = "BtDashBoard";
            this.BtDashBoard.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.BtDashBoard.Size = new System.Drawing.Size(134, 113);
            this.BtDashBoard.Text = "DashBoard";
            this.BtDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtDashBoard.Click += new System.EventHandler(this.BtDashBoard_Click);
            // 
            // BtProduto
            // 
            this.BtProduto.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtProduto.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtProduto.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BtProduto.Image = ((System.Drawing.Image)(resources.GetObject("BtProduto.Image")));
            this.BtProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtProduto.Name = "BtProduto";
            this.BtProduto.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.BtProduto.Size = new System.Drawing.Size(190, 113);
            this.BtProduto.Text = "Cadastro Produtos";
            this.BtProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtProduto.Click += new System.EventHandler(this.BtProduto_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 116);
            // 
            // BtPessoa
            // 
            this.BtPessoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtPessoa.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtPessoa.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BtPessoa.Image = ((System.Drawing.Image)(resources.GetObject("BtPessoa.Image")));
            this.BtPessoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtPessoa.Name = "BtPessoa";
            this.BtPessoa.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.BtPessoa.Size = new System.Drawing.Size(218, 113);
            this.BtPessoa.Text = "Cadastro Fornecedores";
            this.BtPessoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtPessoa.Click += new System.EventHandler(this.BtPessoa_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 116);
            // 
            // BtRelatorio
            // 
            this.BtRelatorio.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BtRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("BtRelatorio.Image")));
            this.BtRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtRelatorio.Name = "BtRelatorio";
            this.BtRelatorio.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.BtRelatorio.Size = new System.Drawing.Size(128, 113);
            this.BtRelatorio.Text = "Relatório";
            this.BtRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtRelatorio.Click += new System.EventHandler(this.BtRelatorio_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBuscas);
            this.tabControl1.Controls.Add(this.tabDashBoard);
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 210);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1160, 462);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabBuscas
            // 
            this.tabBuscas.Controls.Add(this.groupBox2);
            this.tabBuscas.Controls.Add(this.groupBox1);
            this.tabBuscas.Controls.Add(this.pnInfo);
            this.tabBuscas.Controls.Add(this.dgListaCompra);
            this.tabBuscas.Controls.Add(this.ckCancelado);
            this.tabBuscas.Controls.Add(this.txtDataFinal);
            this.tabBuscas.Controls.Add(this.txtDataInicial);
            this.tabBuscas.Controls.Add(this.cbProduto);
            this.tabBuscas.Controls.Add(this.cbFornecedor);
            this.tabBuscas.Controls.Add(this.txtNumNota);
            this.tabBuscas.Controls.Add(this.label5);
            this.tabBuscas.Controls.Add(this.label4);
            this.tabBuscas.Controls.Add(this.label3);
            this.tabBuscas.Controls.Add(this.label2);
            this.tabBuscas.Controls.Add(this.label1);
            this.tabBuscas.Location = new System.Drawing.Point(4, 24);
            this.tabBuscas.Name = "tabBuscas";
            this.tabBuscas.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuscas.Size = new System.Drawing.Size(1152, 434);
            this.tabBuscas.TabIndex = 0;
            this.tabBuscas.Text = "Pesquisas";
            this.tabBuscas.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSomaGeral);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Location = new System.Drawing.Point(970, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 38);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Somatória";
            // 
            // lblSomaGeral
            // 
            this.lblSomaGeral.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomaGeral.ForeColor = System.Drawing.Color.Gray;
            this.lblSomaGeral.Location = new System.Drawing.Point(9, 16);
            this.lblSomaGeral.Name = "lblSomaGeral";
            this.lblSomaGeral.Size = new System.Drawing.Size(150, 19);
            this.lblSomaGeral.TabIndex = 10;
            this.lblSomaGeral.Text = "R$ 0,00";
            this.lblSomaGeral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNCompraCancelada);
            this.groupBox1.Controls.Add(this.lblNCompraNormal);
            this.groupBox1.Controls.Add(this.lblNComprasGeral);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(10, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 38);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nº de Compras";
            // 
            // lblNCompraCancelada
            // 
            this.lblNCompraCancelada.AutoSize = true;
            this.lblNCompraCancelada.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCompraCancelada.ForeColor = System.Drawing.Color.Crimson;
            this.lblNCompraCancelada.Location = new System.Drawing.Point(217, 16);
            this.lblNCompraCancelada.Name = "lblNCompraCancelada";
            this.lblNCompraCancelada.Size = new System.Drawing.Size(0, 14);
            this.lblNCompraCancelada.TabIndex = 10;
            // 
            // lblNCompraNormal
            // 
            this.lblNCompraNormal.AutoSize = true;
            this.lblNCompraNormal.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCompraNormal.ForeColor = System.Drawing.Color.Blue;
            this.lblNCompraNormal.Location = new System.Drawing.Point(120, 16);
            this.lblNCompraNormal.Name = "lblNCompraNormal";
            this.lblNCompraNormal.Size = new System.Drawing.Size(0, 14);
            this.lblNCompraNormal.TabIndex = 10;
            // 
            // lblNComprasGeral
            // 
            this.lblNComprasGeral.AutoSize = true;
            this.lblNComprasGeral.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNComprasGeral.ForeColor = System.Drawing.Color.Gray;
            this.lblNComprasGeral.Location = new System.Drawing.Point(18, 16);
            this.lblNComprasGeral.Name = "lblNComprasGeral";
            this.lblNComprasGeral.Size = new System.Drawing.Size(0, 14);
            this.lblNComprasGeral.TabIndex = 10;
            // 
            // pnInfo
            // 
            this.pnInfo.Controls.Add(this.label6);
            this.pnInfo.Controls.Add(this.pictureBox1);
            this.pnInfo.Location = new System.Drawing.Point(16, 149);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(1119, 152);
            this.pnInfo.TabIndex = 8;
            this.pnInfo.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(300, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(746, 47);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nenhum Registro Foi Localizado...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ckCancelado
            // 
            this.ckCancelado.AutoSize = true;
            this.ckCancelado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ckCancelado.Location = new System.Drawing.Point(1053, 21);
            this.ckCancelado.Name = "ckCancelado";
            this.ckCancelado.Size = new System.Drawing.Size(99, 21);
            this.ckCancelado.TabIndex = 6;
            this.ckCancelado.Text = "Cancelada";
            this.ckCancelado.UseVisualStyleBackColor = true;
            this.ckCancelado.CheckedChanged += new System.EventHandler(this.ckCancelado_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(928, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "até";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(727, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(478, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(181, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fornecedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número Nota";
            // 
            // tabDashBoard
            // 
            this.tabDashBoard.Controls.Add(this.checkBox1);
            this.tabDashBoard.Controls.Add(this.txtCEP1);
            this.tabDashBoard.Location = new System.Drawing.Point(4, 24);
            this.tabDashBoard.Name = "tabDashBoard";
            this.tabDashBoard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashBoard.Size = new System.Drawing.Size(1179, 495);
            this.tabDashBoard.TabIndex = 1;
            this.tabDashBoard.Text = "DashBoard";
            this.tabDashBoard.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(154, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dgListaCompra
            // 
            this.dgListaCompra.AllowUserToAddRows = false;
            this.dgListaCompra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.AliceBlue;
            this.dgListaCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgListaCompra.BackgroundColor = System.Drawing.Color.White;
            this.dgListaCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgListaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COMPRA_ID,
            this.FORNECEDOR,
            this.FINALIDADE,
            this.SITUACAO,
            this.NUM_NOTA,
            this.DATA,
            this.TOTAL,
            this.CADASTRO});
            this.dgListaCompra.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgListaCompra.GridColor = System.Drawing.Color.Black;
            this.dgListaCompra.Location = new System.Drawing.Point(3, 59);
            this.dgListaCompra.Name = "dgListaCompra";
            this.dgListaCompra.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListaCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgListaCompra.RowHeadersWidth = 10;
            this.dgListaCompra.Size = new System.Drawing.Size(1146, 321);
            this.dgListaCompra.TabIndex = 7;
            this.dgListaCompra.TabStop = false;
            // 
            // COMPRA_ID
            // 
            this.COMPRA_ID.DataPropertyName = "COMPRA_ID";
            this.COMPRA_ID.HeaderText = "ID";
            this.COMPRA_ID.Name = "COMPRA_ID";
            this.COMPRA_ID.ReadOnly = true;
            this.COMPRA_ID.Width = 78;
            // 
            // FORNECEDOR
            // 
            this.FORNECEDOR.DataPropertyName = "FORNECEDOR";
            this.FORNECEDOR.HeaderText = "Fornecedor";
            this.FORNECEDOR.Name = "FORNECEDOR";
            this.FORNECEDOR.ReadOnly = true;
            this.FORNECEDOR.Width = 389;
            // 
            // FINALIDADE
            // 
            this.FINALIDADE.DataPropertyName = "FINALIDADE";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FINALIDADE.DefaultCellStyle = dataGridViewCellStyle10;
            this.FINALIDADE.HeaderText = "Finalidade";
            this.FINALIDADE.Name = "FINALIDADE";
            this.FINALIDADE.ReadOnly = true;
            this.FINALIDADE.Width = 110;
            // 
            // SITUACAO
            // 
            this.SITUACAO.DataPropertyName = "SITUACAO";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SITUACAO.DefaultCellStyle = dataGridViewCellStyle11;
            this.SITUACAO.HeaderText = "Situação";
            this.SITUACAO.Name = "SITUACAO";
            this.SITUACAO.ReadOnly = true;
            this.SITUACAO.Width = 108;
            // 
            // NUM_NOTA
            // 
            this.NUM_NOTA.DataPropertyName = "NUM_NOTA";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NUM_NOTA.DefaultCellStyle = dataGridViewCellStyle12;
            this.NUM_NOTA.HeaderText = "Nota";
            this.NUM_NOTA.Name = "NUM_NOTA";
            this.NUM_NOTA.ReadOnly = true;
            this.NUM_NOTA.Width = 120;
            // 
            // DATA
            // 
            this.DATA.DataPropertyName = "DATA";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "d";
            this.DATA.DefaultCellStyle = dataGridViewCellStyle13;
            this.DATA.HeaderText = "Data";
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            this.DATA.Width = 114;
            // 
            // TOTAL
            // 
            this.TOTAL.DataPropertyName = "TOTAL";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "c";
            this.TOTAL.DefaultCellStyle = dataGridViewCellStyle14;
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.Width = 124;
            // 
            // CADASTRO
            // 
            this.CADASTRO.DataPropertyName = "CADATRO";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CADASTRO.DefaultCellStyle = dataGridViewCellStyle15;
            this.CADASTRO.HeaderText = "Cadastro";
            this.CADASTRO.Name = "CADASTRO";
            this.CADASTRO.ReadOnly = true;
            this.CADASTRO.Width = 161;
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDataFinal.Location = new System.Drawing.Point(959, 18);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(79, 23);
            this.txtDataFinal.TabIndex = 5;
            this.txtDataFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataFinal.TextChanged += new System.EventHandler(this.txtDataFinal_TextChanged);
            this.txtDataFinal.Leave += new System.EventHandler(this.txtDataFinal_Leave);
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDataInicial.Location = new System.Drawing.Point(830, 18);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(79, 23);
            this.txtDataInicial.TabIndex = 4;
            this.txtDataInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataInicial.TextChanged += new System.EventHandler(this.txtDataInicial_TextChanged);
            this.txtDataInicial.Leave += new System.EventHandler(this.txtDataInicial_Leave);
            // 
            // cbProduto
            // 
            this.cbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProduto.DisplayMember = "NOME";
            this.cbProduto.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(541, 18);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(166, 23);
            this.cbProduto.TabIndex = 3;
            this.cbProduto.TextChanged += new System.EventHandler(this.cbProduto_TextChanged);
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFornecedor.DisplayMember = "NOME";
            this.cbFornecedor.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(267, 18);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(193, 23);
            this.cbFornecedor.TabIndex = 2;
            this.cbFornecedor.SelectedIndexChanged += new System.EventHandler(this.cbFornecedor_SelectedIndexChanged);
            this.cbFornecedor.TextChanged += new System.EventHandler(this.cbFornecedor_TextChanged);
            // 
            // txtNumNota
            // 
            this.txtNumNota.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumNota.Location = new System.Drawing.Point(100, 18);
            this.txtNumNota.Name = "txtNumNota";
            this.txtNumNota.Size = new System.Drawing.Size(66, 23);
            this.txtNumNota.TabIndex = 1;
            this.txtNumNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumNota.TextChanged += new System.EventHandler(this.txtNumNota_TextChanged);
            // 
            // txtCEP1
            // 
            this.txtCEP1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCEP1.Location = new System.Drawing.Point(361, 42);
            this.txtCEP1.Name = "txtCEP1";
            this.txtCEP1.Size = new System.Drawing.Size(132, 23);
            this.txtCEP1.TabIndex = 0;
            this.txtCEP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoEllipsis = true;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Image = global::Setup.Properties.Resources.round_west_black_36dp;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(1102, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Voltar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(50, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1017, 53);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gerenciamento de Compras";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.White;
            this.panelSuperior.Controls.Add(this.button1);
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1160, 57);
            this.panelSuperior.TabIndex = 2;
            // 
            // frmMenuCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 670);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuCompra";
            this.ShowIcon = false;
            this.Text = "Gerenciamento de Compras";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMenuCompra_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMenuCompra_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabBuscas.ResumeLayout(false);
            this.tabBuscas.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabDashBoard.ResumeLayout(false);
            this.tabDashBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaCompra)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton BtNovo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btAlterar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BtDashBoard;
        private System.Windows.Forms.ToolStripButton BtProduto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BtPessoa;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBuscas;
        private Controles.txtDataLeave txtDataFinal;
        private Controles.txtDataLeave txtDataInicial;
        private Controles.cbCombo cbProduto;
        private Controles.cbCombo cbFornecedor;
        private Controles.txtNumero txtNumNota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabDashBoard;
        private System.Windows.Forms.CheckBox ckCancelado;
        private Controles.dg dgListaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPRA_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORNECEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FINALIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SITUACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_NOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CADASTRO;
        private System.Windows.Forms.CheckBox checkBox1;
        private Controles.txtCEP txtCEP1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton BtRelatorio;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNCompraCancelada;
        private System.Windows.Forms.Label lblNCompraNormal;
        private System.Windows.Forms.Label lblNComprasGeral;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSomaGeral;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelSuperior;
    }
}