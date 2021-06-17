namespace Setup.Formularios
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelRodape = new System.Windows.Forms.Panel();
            this.lblRelogio = new System.Windows.Forms.Label();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblBarra = new System.Windows.Forms.Label();
            this.btFinanceiro = new System.Windows.Forms.Button();
            this.btVendas = new System.Windows.Forms.Button();
            this.BtCompra = new System.Windows.Forms.Button();
            this.btProduto = new System.Windows.Forms.Button();
            this.btnPessoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.txtCPF1 = new Setup.Controles.txtCPF();
            this.panelRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRodape
            // 
            this.panelRodape.BackColor = System.Drawing.Color.Black;
            this.panelRodape.Controls.Add(this.lblRelogio);
            this.panelRodape.Controls.Add(this.lblUsuarioLogado);
            this.panelRodape.Controls.Add(this.pictureBox3);
            this.panelRodape.Controls.Add(this.pictureBox2);
            this.panelRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRodape.Location = new System.Drawing.Point(0, 481);
            this.panelRodape.Name = "panelRodape";
            this.panelRodape.Size = new System.Drawing.Size(930, 40);
            this.panelRodape.TabIndex = 1;
            // 
            // lblRelogio
            // 
            this.lblRelogio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRelogio.BackColor = System.Drawing.Color.Transparent;
            this.lblRelogio.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRelogio.Location = new System.Drawing.Point(558, 4);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(311, 37);
            this.lblRelogio.TabIndex = 1;
            this.lblRelogio.Text = "00:00:00";
            this.lblRelogio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(54, 4);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(421, 37);
            this.lblUsuarioLogado.TabIndex = 1;
            this.lblUsuarioLogado.Text = "AQUI VAI O NOME DO USUÁRIO LOGADO";
            this.lblUsuarioLogado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(891, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 35);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 35);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.lblBarra);
            this.panelMenu.Controls.Add(this.btFinanceiro);
            this.panelMenu.Controls.Add(this.btVendas);
            this.panelMenu.Controls.Add(this.BtCompra);
            this.panelMenu.Controls.Add(this.btProduto);
            this.panelMenu.Controls.Add(this.btnPessoa);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 48);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(214, 433);
            this.panelMenu.TabIndex = 2;
            this.panelMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            // 
            // lblBarra
            // 
            this.lblBarra.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblBarra.Location = new System.Drawing.Point(5, 29);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(5, 49);
            this.lblBarra.TabIndex = 0;
            this.lblBarra.Visible = false;
            // 
            // btFinanceiro
            // 
            this.btFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFinanceiro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btFinanceiro.FlatAppearance.BorderSize = 0;
            this.btFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFinanceiro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinanceiro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btFinanceiro.Image = ((System.Drawing.Image)(resources.GetObject("btFinanceiro.Image")));
            this.btFinanceiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFinanceiro.Location = new System.Drawing.Point(13, 245);
            this.btFinanceiro.Name = "btFinanceiro";
            this.btFinanceiro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btFinanceiro.Size = new System.Drawing.Size(189, 49);
            this.btFinanceiro.TabIndex = 3;
            this.btFinanceiro.Text = "Financeiro";
            this.btFinanceiro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btFinanceiro.UseVisualStyleBackColor = true;
            this.btFinanceiro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btFinanceiro_MouseMove);
            // 
            // btVendas
            // 
            this.btVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVendas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btVendas.FlatAppearance.BorderSize = 0;
            this.btVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVendas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVendas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btVendas.Image = ((System.Drawing.Image)(resources.GetObject("btVendas.Image")));
            this.btVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVendas.Location = new System.Drawing.Point(13, 191);
            this.btVendas.Name = "btVendas";
            this.btVendas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btVendas.Size = new System.Drawing.Size(189, 49);
            this.btVendas.TabIndex = 2;
            this.btVendas.Text = "Vendas";
            this.btVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btVendas.UseVisualStyleBackColor = true;
            this.btVendas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btVendas_MouseMove);
            // 
            // BtCompra
            // 
            this.BtCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtCompra.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtCompra.FlatAppearance.BorderSize = 0;
            this.BtCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtCompra.Image = ((System.Drawing.Image)(resources.GetObject("BtCompra.Image")));
            this.BtCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtCompra.Location = new System.Drawing.Point(13, 137);
            this.BtCompra.Name = "BtCompra";
            this.BtCompra.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtCompra.Size = new System.Drawing.Size(189, 49);
            this.BtCompra.TabIndex = 1;
            this.BtCompra.Text = "Compras";
            this.BtCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtCompra.UseVisualStyleBackColor = true;
            this.BtCompra.Click += new System.EventHandler(this.BtCompra_Click);
            this.BtCompra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtCompra_MouseMove);
            // 
            // btProduto
            // 
            this.btProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btProduto.FlatAppearance.BorderSize = 0;
            this.btProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProduto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btProduto.Image = ((System.Drawing.Image)(resources.GetObject("btProduto.Image")));
            this.btProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btProduto.Location = new System.Drawing.Point(13, 83);
            this.btProduto.Name = "btProduto";
            this.btProduto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btProduto.Size = new System.Drawing.Size(189, 49);
            this.btProduto.TabIndex = 0;
            this.btProduto.Text = "Produtos";
            this.btProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btProduto.UseVisualStyleBackColor = true;
            this.btProduto.Click += new System.EventHandler(this.btProduto_Click);
            this.btProduto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btProduto_MouseMove);
            // 
            // btnPessoa
            // 
            this.btnPessoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPessoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPessoa.FlatAppearance.BorderSize = 0;
            this.btnPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPessoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPessoa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPessoa.Image = global::Setup.Properties.Resources.clientes;
            this.btnPessoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPessoa.Location = new System.Drawing.Point(13, 29);
            this.btnPessoa.Margin = new System.Windows.Forms.Padding(0);
            this.btnPessoa.Name = "btnPessoa";
            this.btnPessoa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPessoa.Size = new System.Drawing.Size(189, 49);
            this.btnPessoa.TabIndex = 0;
            this.btnPessoa.Text = " Pessoas";
            this.btnPessoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPessoa.UseVisualStyleBackColor = true;
            this.btnPessoa.Click += new System.EventHandler(this.btnPessoa_Click);
            this.btnPessoa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnModelo_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(214, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 433);
            this.panel1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTitulo.Location = new System.Drawing.Point(262, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(507, 37);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "SISTEMA GESTOR DE COMÉRCIO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.DoubleClick += new System.EventHandler(this.lblTitulo_DoubleClick);
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Black;
            this.panelSuperior.Controls.Add(this.pictureBox1);
            this.panelSuperior.Controls.Add(this.btnFechar);
            this.panelSuperior.Controls.Add(this.btnMaximize);
            this.panelSuperior.Controls.Add(this.btnMinimizar);
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(930, 48);
            this.panelSuperior.TabIndex = 0;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(883, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(44, 37);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(839, 1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(44, 37);
            this.btnMaximize.TabIndex = 0;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(795, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(44, 37);
            this.btnMinimizar.TabIndex = 0;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // txtCPF1
            // 
            this.txtCPF1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCPF1.Location = new System.Drawing.Point(0, 0);
            this.txtCPF1.Name = "txtCPF1";
            this.txtCPF1.Size = new System.Drawing.Size(100, 23);
            this.txtCPF1.TabIndex = 0;
            this.txtCPF1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelRodape);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyDown);
            this.panelRodape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controles.txtCPF txtCPF1;
        private System.Windows.Forms.Panel panelRodape;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPessoa;
        private System.Windows.Forms.Label lblBarra;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Button btProduto;
        private System.Windows.Forms.Button BtCompra;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btFinanceiro;
        private System.Windows.Forms.Button btVendas;
        public System.Windows.Forms.Panel panel1;
    }
}