namespace Setup.Formularios
{
    partial class frmReceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceber));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grCliente = new System.Windows.Forms.GroupBox();
            this.txtCliente = new Setup.Controles.txt();
            this.txtVencimento = new Setup.Controles.txt();
            this.txtParcela = new Setup.Controles.txt();
            this.txtIdFinanceiro = new Setup.Controles.txt();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdVenda = new Setup.Controles.txt();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grPagamento = new System.Windows.Forms.GroupBox();
            this.txtDesconto = new Setup.Controles.Moeda();
            this.txtAcrescimo = new Setup.Controles.txt();
            this.txtJuros = new Setup.Controles.txt();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.txtMulta = new Setup.Controles.txt();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ckNaoCobrarAcrescimo = new System.Windows.Forms.CheckBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ckAbater = new System.Windows.Forms.CheckBox();
            this.BtReceberDinheiro = new System.Windows.Forms.Button();
            this.lblTroco = new System.Windows.Forms.Label();
            this.txtDinheiro = new Setup.Controles.Moeda();
            this.lblTrocoAux = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txtDividirCredito = new Setup.Controles.txtNumero();
            this.BtCartaoCredito = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtCredito = new Setup.Controles.Moeda();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.BtDebito = new System.Windows.Forms.Button();
            this.label44 = new System.Windows.Forms.Label();
            this.txtDebito = new Setup.Controles.Moeda();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.BtCheque = new System.Windows.Forms.Button();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.txtValorCheque = new Setup.Controles.Moeda();
            this.txtDataCheque = new Setup.Controles.txtDataLeave();
            this.txtNumeroCheque = new Setup.Controles.txtNumero();
            this.cbTitular = new Setup.Controles.cbCombo();
            this.label29 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grLista = new System.Windows.Forms.GroupBox();
            this.dgFinanceiro = new Setup.Controles.dg();
            this.FINANCEIRO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Multa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasVencidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPgt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblFaltaPagar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grCliente.SuspendLayout();
            this.grPagamento.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFinanceiro)).BeginInit();
            this.SuspendLayout();
            // 
            // grCliente
            // 
            this.grCliente.Controls.Add(this.txtCliente);
            this.grCliente.Controls.Add(this.txtVencimento);
            this.grCliente.Controls.Add(this.txtParcela);
            this.grCliente.Controls.Add(this.txtIdFinanceiro);
            this.grCliente.Controls.Add(this.label2);
            this.grCliente.Controls.Add(this.txtIdVenda);
            this.grCliente.Controls.Add(this.lblTotal);
            this.grCliente.Controls.Add(this.label4);
            this.grCliente.Controls.Add(this.label3);
            this.grCliente.Controls.Add(this.label1);
            this.grCliente.Location = new System.Drawing.Point(12, 6);
            this.grCliente.Name = "grCliente";
            this.grCliente.Size = new System.Drawing.Size(680, 105);
            this.grCliente.TabIndex = 0;
            this.grCliente.TabStop = false;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCliente.Location = new System.Drawing.Point(278, 28);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(382, 23);
            this.txtCliente.TabIndex = 1;
            // 
            // txtVencimento
            // 
            this.txtVencimento.Enabled = false;
            this.txtVencimento.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVencimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVencimento.Location = new System.Drawing.Point(363, 63);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Size = new System.Drawing.Size(101, 23);
            this.txtVencimento.TabIndex = 1;
            this.txtVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtParcela
            // 
            this.txtParcela.Enabled = false;
            this.txtParcela.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtParcela.Location = new System.Drawing.Point(116, 63);
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(126, 23);
            this.txtParcela.TabIndex = 1;
            // 
            // txtIdFinanceiro
            // 
            this.txtIdFinanceiro.Enabled = false;
            this.txtIdFinanceiro.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFinanceiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdFinanceiro.Location = new System.Drawing.Point(116, 28);
            this.txtIdFinanceiro.Name = "txtIdFinanceiro";
            this.txtIdFinanceiro.Size = new System.Drawing.Size(78, 23);
            this.txtIdFinanceiro.TabIndex = 1;
            this.txtIdFinanceiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente:";
            // 
            // txtIdVenda
            // 
            this.txtIdVenda.BackColor = System.Drawing.Color.White;
            this.txtIdVenda.Enabled = false;
            this.txtIdVenda.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdVenda.Location = new System.Drawing.Point(6, 51);
            this.txtIdVenda.Name = "txtIdVenda";
            this.txtIdVenda.Size = new System.Drawing.Size(42, 23);
            this.txtIdVenda.TabIndex = 1;
            this.txtIdVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(470, 54);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(190, 48);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "R$ 0,00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vencimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pagando:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Parcela:";
            // 
            // grPagamento
            // 
            this.grPagamento.Controls.Add(this.txtDesconto);
            this.grPagamento.Controls.Add(this.txtAcrescimo);
            this.grPagamento.Controls.Add(this.txtJuros);
            this.grPagamento.Controls.Add(this.label6);
            this.grPagamento.Controls.Add(this.lblDias);
            this.grPagamento.Controls.Add(this.lblValorPago);
            this.grPagamento.Controls.Add(this.txtMulta);
            this.grPagamento.Controls.Add(this.label7);
            this.grPagamento.Controls.Add(this.label9);
            this.grPagamento.Location = new System.Drawing.Point(12, 117);
            this.grPagamento.Name = "grPagamento";
            this.grPagamento.Size = new System.Drawing.Size(680, 105);
            this.grPagamento.TabIndex = 0;
            this.grPagamento.TabStop = false;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDesconto.Location = new System.Drawing.Point(116, 70);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(78, 23);
            this.txtDesconto.TabIndex = 2;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            // 
            // txtAcrescimo
            // 
            this.txtAcrescimo.BackColor = System.Drawing.Color.White;
            this.txtAcrescimo.Enabled = false;
            this.txtAcrescimo.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcrescimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAcrescimo.Location = new System.Drawing.Point(552, 28);
            this.txtAcrescimo.Name = "txtAcrescimo";
            this.txtAcrescimo.Size = new System.Drawing.Size(108, 23);
            this.txtAcrescimo.TabIndex = 1;
            this.txtAcrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtJuros
            // 
            this.txtJuros.Enabled = false;
            this.txtJuros.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJuros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtJuros.Location = new System.Drawing.Point(334, 31);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(78, 23);
            this.txtJuros.TabIndex = 1;
            this.txtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Acréscimo";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(200, 34);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(128, 17);
            this.lblDias.TabIndex = 0;
            this.lblDias.Text = "0 Dias de Juros";
            // 
            // lblValorPago
            // 
            this.lblValorPago.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPago.Location = new System.Drawing.Point(470, 57);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(190, 45);
            this.lblValorPago.TabIndex = 0;
            this.lblValorPago.Text = "R$ 0,00";
            this.lblValorPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMulta
            // 
            this.txtMulta.Enabled = false;
            this.txtMulta.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMulta.Location = new System.Drawing.Point(116, 28);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(78, 23);
            this.txtMulta.TabIndex = 1;
            this.txtMulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Desconto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "R$ Multa";
            // 
            // ckNaoCobrarAcrescimo
            // 
            this.ckNaoCobrarAcrescimo.AutoSize = true;
            this.ckNaoCobrarAcrescimo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckNaoCobrarAcrescimo.ForeColor = System.Drawing.Color.DarkGray;
            this.ckNaoCobrarAcrescimo.Location = new System.Drawing.Point(359, 235);
            this.ckNaoCobrarAcrescimo.Name = "ckNaoCobrarAcrescimo";
            this.ckNaoCobrarAcrescimo.Size = new System.Drawing.Size(327, 18);
            this.ckNaoCobrarAcrescimo.TabIndex = 3;
            this.ckNaoCobrarAcrescimo.Text = "Não Cobrar Juros e Multa de Nenhuma Parcela";
            this.ckNaoCobrarAcrescimo.UseVisualStyleBackColor = true;
            this.ckNaoCobrarAcrescimo.CheckedChanged += new System.EventHandler(this.ckNaoCobrarAcrescimo_CheckedChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.ItemSize = new System.Drawing.Size(150, 20);
            this.tabControl2.Location = new System.Drawing.Point(8, 255);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(285, 201);
            this.tabControl2.TabIndex = 10;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ckAbater);
            this.tabPage5.Controls.Add(this.BtReceberDinheiro);
            this.tabPage5.Controls.Add(this.lblTroco);
            this.tabPage5.Controls.Add(this.txtDinheiro);
            this.tabPage5.Controls.Add(this.lblTrocoAux);
            this.tabPage5.Controls.Add(this.label42);
            this.tabPage5.Controls.Add(this.label40);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(277, 173);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Dinheiro";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // ckAbater
            // 
            this.ckAbater.AutoSize = true;
            this.ckAbater.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckAbater.ForeColor = System.Drawing.Color.Gray;
            this.ckAbater.Location = new System.Drawing.Point(26, 82);
            this.ckAbater.Name = "ckAbater";
            this.ckAbater.Size = new System.Drawing.Size(68, 18);
            this.ckAbater.TabIndex = 12;
            this.ckAbater.Text = "Abater";
            this.ckAbater.UseVisualStyleBackColor = true;
            this.ckAbater.Visible = false;
            this.ckAbater.CheckedChanged += new System.EventHandler(this.ckAbater_CheckedChanged);
            // 
            // BtReceberDinheiro
            // 
            this.BtReceberDinheiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtReceberDinheiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtReceberDinheiro.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtReceberDinheiro.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.BtReceberDinheiro.Image = ((System.Drawing.Image)(resources.GetObject("BtReceberDinheiro.Image")));
            this.BtReceberDinheiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtReceberDinheiro.Location = new System.Drawing.Point(132, 53);
            this.BtReceberDinheiro.Name = "BtReceberDinheiro";
            this.BtReceberDinheiro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtReceberDinheiro.Size = new System.Drawing.Size(124, 45);
            this.BtReceberDinheiro.TabIndex = 15;
            this.BtReceberDinheiro.Text = "Salvar";
            this.BtReceberDinheiro.UseVisualStyleBackColor = true;
            this.BtReceberDinheiro.Click += new System.EventHandler(this.BtReceberDinheiro_Click);
            // 
            // lblTroco
            // 
            this.lblTroco.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.Color.Gray;
            this.lblTroco.Location = new System.Drawing.Point(25, 115);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(196, 39);
            this.lblTroco.TabIndex = 5;
            this.lblTroco.Text = "R$ 0,00";
            this.lblTroco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.BackColor = System.Drawing.Color.White;
            this.txtDinheiro.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinheiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDinheiro.Location = new System.Drawing.Point(26, 53);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(100, 23);
            this.txtDinheiro.TabIndex = 1;
            this.txtDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDinheiro.TextChanged += new System.EventHandler(this.txtDinheiro_TextChanged);
            // 
            // lblTrocoAux
            // 
            this.lblTrocoAux.AutoSize = true;
            this.lblTrocoAux.ForeColor = System.Drawing.Color.Gray;
            this.lblTrocoAux.Location = new System.Drawing.Point(208, 150);
            this.lblTrocoAux.Name = "lblTrocoAux";
            this.lblTrocoAux.Size = new System.Drawing.Size(64, 17);
            this.lblTrocoAux.TabIndex = 0;
            this.lblTrocoAux.Text = "R$ 0,00";
            this.lblTrocoAux.Visible = false;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.ForeColor = System.Drawing.Color.Gray;
            this.label42.Location = new System.Drawing.Point(29, 150);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(48, 17);
            this.label42.TabIndex = 0;
            this.label42.Text = "Troco";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.ForeColor = System.Drawing.Color.Gray;
            this.label40.Location = new System.Drawing.Point(23, 32);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(216, 17);
            this.label40.TabIndex = 0;
            this.label40.Text = "Valor Recebido em Dinheiro";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.txtDividirCredito);
            this.tabPage6.Controls.Add(this.BtCartaoCredito);
            this.tabPage6.Controls.Add(this.label37);
            this.tabPage6.Controls.Add(this.label35);
            this.tabPage6.Controls.Add(this.label38);
            this.tabPage6.Controls.Add(this.txtCredito);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(277, 173);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Crédito";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // txtDividirCredito
            // 
            this.txtDividirCredito.BackColor = System.Drawing.Color.White;
            this.txtDividirCredito.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDividirCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDividirCredito.Location = new System.Drawing.Point(142, 83);
            this.txtDividirCredito.Name = "txtDividirCredito";
            this.txtDividirCredito.Size = new System.Drawing.Size(46, 23);
            this.txtDividirCredito.TabIndex = 21;
            this.txtDividirCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtCartaoCredito
            // 
            this.BtCartaoCredito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtCartaoCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCartaoCredito.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCartaoCredito.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.BtCartaoCredito.Image = ((System.Drawing.Image)(resources.GetObject("BtCartaoCredito.Image")));
            this.BtCartaoCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtCartaoCredito.Location = new System.Drawing.Point(112, 112);
            this.BtCartaoCredito.Name = "BtCartaoCredito";
            this.BtCartaoCredito.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtCartaoCredito.Size = new System.Drawing.Size(130, 45);
            this.BtCartaoCredito.TabIndex = 20;
            this.BtCartaoCredito.Text = "Salvar";
            this.BtCartaoCredito.UseVisualStyleBackColor = true;
            this.BtCartaoCredito.Click += new System.EventHandler(this.BtCartaoCredito_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.ForeColor = System.Drawing.Color.Gray;
            this.label37.Location = new System.Drawing.Point(194, 86);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(48, 17);
            this.label37.TabIndex = 17;
            this.label37.Text = "vezes";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.Color.Gray;
            this.label35.Location = new System.Drawing.Point(40, 89);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(96, 17);
            this.label35.TabIndex = 17;
            this.label35.Text = "Dividido em";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.ForeColor = System.Drawing.Color.Gray;
            this.label38.Location = new System.Drawing.Point(40, 26);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(176, 17);
            this.label38.TabIndex = 17;
            this.label38.Text = "Valor Pago no Crédito";
            // 
            // txtCredito
            // 
            this.txtCredito.BackColor = System.Drawing.Color.White;
            this.txtCredito.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCredito.Location = new System.Drawing.Point(142, 46);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(100, 23);
            this.txtCredito.TabIndex = 18;
            this.txtCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.BtDebito);
            this.tabPage7.Controls.Add(this.label44);
            this.tabPage7.Controls.Add(this.txtDebito);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(277, 173);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Débito";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // BtDebito
            // 
            this.BtDebito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtDebito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtDebito.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDebito.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.BtDebito.Image = ((System.Drawing.Image)(resources.GetObject("BtDebito.Image")));
            this.BtDebito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtDebito.Location = new System.Drawing.Point(86, 103);
            this.BtDebito.Name = "BtDebito";
            this.BtDebito.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtDebito.Size = new System.Drawing.Size(130, 45);
            this.BtDebito.TabIndex = 26;
            this.BtDebito.Text = "Salvar";
            this.BtDebito.UseVisualStyleBackColor = true;
            this.BtDebito.Click += new System.EventHandler(this.BtDebito_Click);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.ForeColor = System.Drawing.Color.Gray;
            this.label44.Location = new System.Drawing.Point(41, 33);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(168, 17);
            this.label44.TabIndex = 24;
            this.label44.Text = "Valor Pago no Débito";
            // 
            // txtDebito
            // 
            this.txtDebito.BackColor = System.Drawing.Color.White;
            this.txtDebito.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDebito.Location = new System.Drawing.Point(141, 62);
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.Size = new System.Drawing.Size(75, 23);
            this.txtDebito.TabIndex = 25;
            this.txtDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.BtCheque);
            this.tabPage8.Controls.Add(this.label46);
            this.tabPage8.Controls.Add(this.label45);
            this.tabPage8.Controls.Add(this.label43);
            this.tabPage8.Controls.Add(this.label41);
            this.tabPage8.Controls.Add(this.txtValorCheque);
            this.tabPage8.Controls.Add(this.txtDataCheque);
            this.tabPage8.Controls.Add(this.txtNumeroCheque);
            this.tabPage8.Controls.Add(this.cbTitular);
            this.tabPage8.Location = new System.Drawing.Point(4, 24);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(277, 173);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "Cheque";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // BtCheque
            // 
            this.BtCheque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtCheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCheque.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCheque.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.BtCheque.Image = ((System.Drawing.Image)(resources.GetObject("BtCheque.Image")));
            this.BtCheque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtCheque.Location = new System.Drawing.Point(128, 118);
            this.BtCheque.Name = "BtCheque";
            this.BtCheque.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtCheque.Size = new System.Drawing.Size(123, 45);
            this.BtCheque.TabIndex = 30;
            this.BtCheque.Text = "Salvar";
            this.BtCheque.UseVisualStyleBackColor = true;
            this.BtCheque.Click += new System.EventHandler(this.BtCheque_Click);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.ForeColor = System.Drawing.Color.Gray;
            this.label46.Location = new System.Drawing.Point(29, 120);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(48, 17);
            this.label46.TabIndex = 25;
            this.label46.Text = "Valor";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.ForeColor = System.Drawing.Color.Gray;
            this.label45.Location = new System.Drawing.Point(154, 59);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(40, 17);
            this.label45.TabIndex = 25;
            this.label45.Text = "Data";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.ForeColor = System.Drawing.Color.Gray;
            this.label43.Location = new System.Drawing.Point(29, 59);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(56, 17);
            this.label43.TabIndex = 25;
            this.label43.Text = "Numero";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.ForeColor = System.Drawing.Color.Gray;
            this.label41.Location = new System.Drawing.Point(27, 12);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(120, 17);
            this.label41.TabIndex = 25;
            this.label41.Text = "Titular Cheque";
            // 
            // txtValorCheque
            // 
            this.txtValorCheque.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCheque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValorCheque.Location = new System.Drawing.Point(26, 140);
            this.txtValorCheque.Name = "txtValorCheque";
            this.txtValorCheque.Size = new System.Drawing.Size(96, 23);
            this.txtValorCheque.TabIndex = 29;
            this.txtValorCheque.Tag = "Valor do Cheque";
            this.txtValorCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDataCheque
            // 
            this.txtDataCheque.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataCheque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDataCheque.Location = new System.Drawing.Point(151, 79);
            this.txtDataCheque.Name = "txtDataCheque";
            this.txtDataCheque.Size = new System.Drawing.Size(100, 23);
            this.txtDataCheque.TabIndex = 28;
            this.txtDataCheque.Tag = "Data do Cheque";
            this.txtDataCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumeroCheque
            // 
            this.txtNumeroCheque.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCheque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumeroCheque.Location = new System.Drawing.Point(26, 79);
            this.txtNumeroCheque.Name = "txtNumeroCheque";
            this.txtNumeroCheque.Size = new System.Drawing.Size(100, 23);
            this.txtNumeroCheque.TabIndex = 27;
            this.txtNumeroCheque.Tag = "Número do Cheque";
            this.txtNumeroCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbTitular
            // 
            this.cbTitular.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTitular.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTitular.BackColor = System.Drawing.Color.White;
            this.cbTitular.DisplayMember = "TITULAR";
            this.cbTitular.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTitular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbTitular.FormattingEnabled = true;
            this.cbTitular.Location = new System.Drawing.Point(26, 32);
            this.cbTitular.MaxLength = 80;
            this.cbTitular.Name = "cbTitular";
            this.cbTitular.Size = new System.Drawing.Size(225, 23);
            this.cbTitular.TabIndex = 26;
            this.cbTitular.Tag = "Titular do Cheque";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.Gray;
            this.label29.Location = new System.Drawing.Point(12, 235);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(160, 17);
            this.label29.TabIndex = 9;
            this.label29.Text = "Opções de Pagamento";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // grLista
            // 
            this.grLista.Controls.Add(this.dgFinanceiro);
            this.grLista.Location = new System.Drawing.Point(299, 255);
            this.grLista.Name = "grLista";
            this.grLista.Size = new System.Drawing.Size(393, 201);
            this.grLista.TabIndex = 11;
            this.grLista.TabStop = false;
            // 
            // dgFinanceiro
            // 
            this.dgFinanceiro.AllowUserToAddRows = false;
            this.dgFinanceiro.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgFinanceiro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgFinanceiro.BackgroundColor = System.Drawing.Color.White;
            this.dgFinanceiro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgFinanceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFinanceiro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FINANCEIRO_ID,
            this.Vencimento,
            this.Parcela,
            this.Valor,
            this.Desconto,
            this.Juros,
            this.Multa,
            this.Total,
            this.Pagou,
            this.DiasVencidos,
            this.TipoPgt});
            this.dgFinanceiro.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgFinanceiro.GridColor = System.Drawing.Color.Black;
            this.dgFinanceiro.Location = new System.Drawing.Point(6, 14);
            this.dgFinanceiro.Name = "dgFinanceiro";
            this.dgFinanceiro.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFinanceiro.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgFinanceiro.RowHeadersWidth = 10;
            this.dgFinanceiro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFinanceiro.Size = new System.Drawing.Size(381, 177);
            this.dgFinanceiro.TabIndex = 0;
            this.dgFinanceiro.TabStop = false;
            this.dgFinanceiro.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgFinanceiro_CellFormatting);
            // 
            // FINANCEIRO_ID
            // 
            this.FINANCEIRO_ID.DataPropertyName = "FINANCEIRO_ID";
            this.FINANCEIRO_ID.HeaderText = "FINANCEIRO_ID";
            this.FINANCEIRO_ID.Name = "FINANCEIRO_ID";
            this.FINANCEIRO_ID.ReadOnly = true;
            this.FINANCEIRO_ID.Visible = false;
            // 
            // Vencimento
            // 
            this.Vencimento.DataPropertyName = "VENCIMENTO";
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.ReadOnly = true;
            this.Vencimento.Width = 92;
            // 
            // Parcela
            // 
            this.Parcela.DataPropertyName = "NUM_PARCELA";
            this.Parcela.HeaderText = "Parc";
            this.Parcela.Name = "Parcela";
            this.Parcela.ReadOnly = true;
            this.Parcela.Width = 46;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "VALOR";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle2;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Desconto
            // 
            this.Desconto.DataPropertyName = "DESCONTO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.Desconto.DefaultCellStyle = dataGridViewCellStyle3;
            this.Desconto.HeaderText = "Desc";
            this.Desconto.Name = "Desconto";
            this.Desconto.ReadOnly = true;
            this.Desconto.Width = 62;
            // 
            // Juros
            // 
            this.Juros.DataPropertyName = "JURO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.Juros.DefaultCellStyle = dataGridViewCellStyle4;
            this.Juros.HeaderText = "Juros";
            this.Juros.Name = "Juros";
            this.Juros.ReadOnly = true;
            this.Juros.Width = 60;
            // 
            // Multa
            // 
            this.Multa.DataPropertyName = "MULTA";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.Multa.DefaultCellStyle = dataGridViewCellStyle5;
            this.Multa.HeaderText = "Multa";
            this.Multa.Name = "Multa";
            this.Multa.ReadOnly = true;
            this.Multa.Width = 60;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "TOTAL";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.Total.DefaultCellStyle = dataGridViewCellStyle6;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Pagou
            // 
            this.Pagou.DataPropertyName = "DATA_PAGOU";
            this.Pagou.HeaderText = "Pagou";
            this.Pagou.Name = "Pagou";
            this.Pagou.ReadOnly = true;
            // 
            // DiasVencidos
            // 
            this.DiasVencidos.DataPropertyName = "DIAS_VENCIDOS";
            this.DiasVencidos.HeaderText = "Dias Vencidos";
            this.DiasVencidos.Name = "DiasVencidos";
            this.DiasVencidos.ReadOnly = true;
            this.DiasVencidos.Visible = false;
            // 
            // TipoPgt
            // 
            this.TipoPgt.DataPropertyName = "TIPO_PGT";
            this.TipoPgt.HeaderText = "Tipo Pgt";
            this.TipoPgt.Name = "TipoPgt";
            this.TipoPgt.ReadOnly = true;
            // 
            // lblAviso
            // 
            this.lblAviso.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAviso.Location = new System.Drawing.Point(12, 459);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(338, 54);
            this.lblAviso.TabIndex = 0;
            this.lblAviso.Text = "Venda Finalizada, Não é Permitido Alterações!";
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAviso.Visible = false;
            // 
            // lblFaltaPagar
            // 
            this.lblFaltaPagar.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltaPagar.Location = new System.Drawing.Point(496, 460);
            this.lblFaltaPagar.Name = "lblFaltaPagar";
            this.lblFaltaPagar.Size = new System.Drawing.Size(190, 45);
            this.lblFaltaPagar.TabIndex = 0;
            this.lblFaltaPagar.Text = "R$ 0,00";
            this.lblFaltaPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(516, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor Total à Receber";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Setup.Relatorios.Comprovante.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(698, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(335, 246);
            this.reportViewer1.TabIndex = 12;
            this.reportViewer1.Visible = false;
            // 
            // frmReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 513);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.ckNaoCobrarAcrescimo);
            this.Controls.Add(this.grLista);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.grPagamento);
            this.Controls.Add(this.grCliente);
            this.Controls.Add(this.lblFaltaPagar);
            this.Controls.Add(this.lblAviso);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReceber";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recebimento de Crediário Próprio";
            this.Load += new System.EventHandler(this.frmReceber_Load);
            this.grCliente.ResumeLayout(false);
            this.grCliente.PerformLayout();
            this.grPagamento.ResumeLayout(false);
            this.grPagamento.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFinanceiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public Controles.txt txtIdFinanceiro;
        public Controles.txt txtCliente;
        public Controles.txt txtVencimento;
        public Controles.txt txtParcela;
        public System.Windows.Forms.Label lblTotal;
        public Controles.Moeda txtDesconto;
        public Controles.txt txtAcrescimo;
        public Controles.txt txtJuros;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblValorPago;
        public Controles.txt txtMulta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.CheckBox ckNaoCobrarAcrescimo;
        private System.Windows.Forms.Button BtReceberDinheiro;
        private System.Windows.Forms.Label lblTroco;
        private Controles.Moeda txtDinheiro;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TabPage tabPage6;
        private Controles.txtNumero txtDividirCredito;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TabPage tabPage8;
        private Controles.txtDataLeave txtDataCheque;
        private Controles.txtNumero txtNumeroCheque;
        private Controles.cbCombo cbTitular;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public Controles.txt txtIdVenda;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button BtCartaoCredito;
        private System.Windows.Forms.Label label38;
        private Controles.Moeda txtCredito;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button BtDebito;
        private System.Windows.Forms.Label label44;
        private Controles.Moeda txtDebito;
        private System.Windows.Forms.Button BtCheque;
        private System.Windows.Forms.Label label46;
        private Controles.Moeda txtValorCheque;
        private Controles.dg dgFinanceiro;
        private System.Windows.Forms.CheckBox ckAbater;
        private System.Windows.Forms.Label lblTrocoAux;
        public System.Windows.Forms.Label lblAviso;
        public System.Windows.Forms.GroupBox grCliente;
        public System.Windows.Forms.GroupBox grPagamento;
        public System.Windows.Forms.TabControl tabControl2;
        public System.Windows.Forms.GroupBox grLista;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblFaltaPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FINANCEIRO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Multa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagou;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasVencidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPgt;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}