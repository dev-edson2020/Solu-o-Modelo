namespace Setup.Formularios
{
    partial class frmFinanceiro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotalGeral = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTotalRecebido = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblFaltaReceber = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblTotalCredito = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblTotalDebito = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblTotalCheque = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblTotalDinheiro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.cbTipoPagamento = new Setup.Controles.cbCombo();
            this.ckTodos = new System.Windows.Forms.CheckBox();
            this.ckNaoPago = new System.Windows.Forms.CheckBox();
            this.ckPago = new System.Windows.Forms.CheckBox();
            this.ckVencidos = new System.Windows.Forms.CheckBox();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.cbProduto = new Setup.Controles.cbCombo();
            this.cbCliente = new Setup.Controles.cbCombo();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txIdBoleto = new Setup.Controles.txtNumero();
            this.txtIdVenda = new Setup.Controles.txtNumero();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgFinanceiro = new Setup.Controles.dg();
            this.IdVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBoleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Multas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPgt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasVencidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lblVencidos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFinanceiro)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotalGeral);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox3.Location = new System.Drawing.Point(12, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 56);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total Geral";
            // 
            // lblTotalGeral
            // 
            this.lblTotalGeral.Location = new System.Drawing.Point(6, 19);
            this.lblTotalGeral.Name = "lblTotalGeral";
            this.lblTotalGeral.Size = new System.Drawing.Size(142, 34);
            this.lblTotalGeral.TabIndex = 0;
            this.lblTotalGeral.Text = "R$ 0,00";
            this.lblTotalGeral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTotalRecebido);
            this.groupBox4.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox4.Location = new System.Drawing.Point(178, 115);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(136, 56);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total Recebido";
            // 
            // lblTotalRecebido
            // 
            this.lblTotalRecebido.Location = new System.Drawing.Point(6, 19);
            this.lblTotalRecebido.Name = "lblTotalRecebido";
            this.lblTotalRecebido.Size = new System.Drawing.Size(121, 34);
            this.lblTotalRecebido.TabIndex = 0;
            this.lblTotalRecebido.Text = "R$ 0,00";
            this.lblTotalRecebido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblFaltaReceber);
            this.groupBox5.ForeColor = System.Drawing.Color.Navy;
            this.groupBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox5.Location = new System.Drawing.Point(327, 115);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(136, 56);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Falta Receber";
            // 
            // lblFaltaReceber
            // 
            this.lblFaltaReceber.Location = new System.Drawing.Point(6, 19);
            this.lblFaltaReceber.Name = "lblFaltaReceber";
            this.lblFaltaReceber.Size = new System.Drawing.Size(124, 34);
            this.lblFaltaReceber.TabIndex = 0;
            this.lblFaltaReceber.Text = "R$ 0,00";
            this.lblFaltaReceber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblTotalCredito);
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox6.Location = new System.Drawing.Point(625, 115);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(137, 56);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Vendas Crédito";
            // 
            // lblTotalCredito
            // 
            this.lblTotalCredito.Location = new System.Drawing.Point(6, 19);
            this.lblTotalCredito.Name = "lblTotalCredito";
            this.lblTotalCredito.Size = new System.Drawing.Size(129, 34);
            this.lblTotalCredito.TabIndex = 0;
            this.lblTotalCredito.Text = "R$ 0,00";
            this.lblTotalCredito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblTotalDebito);
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox7.Location = new System.Drawing.Point(775, 115);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(146, 56);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Vendas Débito";
            // 
            // lblTotalDebito
            // 
            this.lblTotalDebito.Location = new System.Drawing.Point(6, 19);
            this.lblTotalDebito.Name = "lblTotalDebito";
            this.lblTotalDebito.Size = new System.Drawing.Size(139, 34);
            this.lblTotalDebito.TabIndex = 0;
            this.lblTotalDebito.Text = "R$ 0,00";
            this.lblTotalDebito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblTotalCheque);
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox8.Location = new System.Drawing.Point(934, 115);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(151, 56);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Vendas Cheque";
            // 
            // lblTotalCheque
            // 
            this.lblTotalCheque.Location = new System.Drawing.Point(6, 19);
            this.lblTotalCheque.Name = "lblTotalCheque";
            this.lblTotalCheque.Size = new System.Drawing.Size(134, 34);
            this.lblTotalCheque.TabIndex = 0;
            this.lblTotalCheque.Text = "R$ 0,00";
            this.lblTotalCheque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblTotalDinheiro);
            this.groupBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox9.Location = new System.Drawing.Point(1098, 115);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(152, 56);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Vendas Dinheiro";
            // 
            // lblTotalDinheiro
            // 
            this.lblTotalDinheiro.Location = new System.Drawing.Point(6, 19);
            this.lblTotalDinheiro.Name = "lblTotalDinheiro";
            this.lblTotalDinheiro.Size = new System.Drawing.Size(140, 34);
            this.lblTotalDinheiro.TabIndex = 0;
            this.lblTotalDinheiro.Text = "R$ 0,00";
            this.lblTotalDinheiro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 655);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(544, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Selecione um item na lista e pressione Control + Enter para Receber";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btBuscar);
            this.groupBox2.Controls.Add(this.cbTipoPagamento);
            this.groupBox2.Controls.Add(this.ckTodos);
            this.groupBox2.Controls.Add(this.ckNaoPago);
            this.groupBox2.Controls.Add(this.ckPago);
            this.groupBox2.Controls.Add(this.ckVencidos);
            this.groupBox2.Controls.Add(this.txtData);
            this.groupBox2.Controls.Add(this.cbProduto);
            this.groupBox2.Controls.Add(this.cbCliente);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(220, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1032, 84);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informe os dados da busca e clique no botão da direita";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(951, 22);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(52, 50);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // cbTipoPagamento
            // 
            this.cbTipoPagamento.DisplayMember = "TIPO_PGT";
            this.cbTipoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPagamento.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbTipoPagamento.FormattingEnabled = true;
            this.cbTipoPagamento.Location = new System.Drawing.Point(620, 43);
            this.cbTipoPagamento.Name = "cbTipoPagamento";
            this.cbTipoPagamento.Size = new System.Drawing.Size(114, 23);
            this.cbTipoPagamento.TabIndex = 8;
            this.cbTipoPagamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbTipoPagamento_KeyDown);
            this.cbTipoPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTipoPagamento_KeyPress);
            // 
            // ckTodos
            // 
            this.ckTodos.AutoSize = true;
            this.ckTodos.Location = new System.Drawing.Point(853, 49);
            this.ckTodos.Name = "ckTodos";
            this.ckTodos.Size = new System.Drawing.Size(67, 21);
            this.ckTodos.TabIndex = 7;
            this.ckTodos.Text = "Todos";
            this.ckTodos.UseVisualStyleBackColor = true;
            this.ckTodos.CheckedChanged += new System.EventHandler(this.ckTodos_CheckedChanged);
            // 
            // ckNaoPago
            // 
            this.ckNaoPago.AutoSize = true;
            this.ckNaoPago.Location = new System.Drawing.Point(754, 47);
            this.ckNaoPago.Name = "ckNaoPago";
            this.ckNaoPago.Size = new System.Drawing.Size(91, 21);
            this.ckNaoPago.TabIndex = 6;
            this.ckNaoPago.Text = "Não Pago";
            this.ckNaoPago.UseVisualStyleBackColor = true;
            this.ckNaoPago.CheckedChanged += new System.EventHandler(this.ckNaoPago_CheckedChanged);
            // 
            // ckPago
            // 
            this.ckPago.AutoSize = true;
            this.ckPago.Location = new System.Drawing.Point(754, 22);
            this.ckPago.Name = "ckPago";
            this.ckPago.Size = new System.Drawing.Size(59, 21);
            this.ckPago.TabIndex = 5;
            this.ckPago.Text = "Pago";
            this.ckPago.UseVisualStyleBackColor = true;
            this.ckPago.CheckedChanged += new System.EventHandler(this.ckPago_CheckedChanged);
            // 
            // ckVencidos
            // 
            this.ckVencidos.AutoSize = true;
            this.ckVencidos.Location = new System.Drawing.Point(853, 22);
            this.ckVencidos.Name = "ckVencidos";
            this.ckVencidos.Size = new System.Drawing.Size(91, 21);
            this.ckVencidos.TabIndex = 4;
            this.ckVencidos.Text = "Vencidos";
            this.ckVencidos.UseVisualStyleBackColor = true;
            this.ckVencidos.CheckedChanged += new System.EventHandler(this.ckVencidos_CheckedChanged);
            // 
            // txtData
            // 
            this.txtData.CalendarForeColor = System.Drawing.Color.Gray;
            this.txtData.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtData.CustomFormat = " ";
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtData.Location = new System.Drawing.Point(507, 44);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(107, 23);
            this.txtData.TabIndex = 3;
            this.txtData.ValueChanged += new System.EventHandler(this.txtData_ValueChanged);
            // 
            // cbProduto
            // 
            this.cbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProduto.DisplayMember = "NOME";
            this.cbProduto.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(306, 43);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(195, 23);
            this.cbProduto.TabIndex = 2;
            this.cbProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbProduto_KeyPress);
            this.cbProduto.Leave += new System.EventHandler(this.cbProduto_Leave);
            // 
            // cbCliente
            // 
            this.cbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCliente.DisplayMember = "NOME";
            this.cbCliente.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(25, 43);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(275, 23);
            this.cbCliente.TabIndex = 1;
            this.cbCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCliente_KeyPress);
            this.cbCliente.Leave += new System.EventHandler(this.cbCliente_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(631, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tipo Pgt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vence Até";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txIdBoleto);
            this.groupBox1.Controls.Add(this.txtIdVenda);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca Exata";
            // 
            // txIdBoleto
            // 
            this.txIdBoleto.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txIdBoleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txIdBoleto.Location = new System.Drawing.Point(101, 47);
            this.txIdBoleto.Name = "txIdBoleto";
            this.txIdBoleto.Size = new System.Drawing.Size(90, 23);
            this.txIdBoleto.TabIndex = 3;
            this.txIdBoleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txIdBoleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txIdBoleto_KeyPress);
            this.txIdBoleto.Leave += new System.EventHandler(this.txIdBoleto_Leave);
            // 
            // txtIdVenda
            // 
            this.txtIdVenda.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdVenda.Location = new System.Drawing.Point(8, 47);
            this.txtIdVenda.Name = "txtIdVenda";
            this.txtIdVenda.Size = new System.Drawing.Size(87, 23);
            this.txtIdVenda.TabIndex = 2;
            this.txtIdVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdVenda_KeyPress);
            this.txtIdVenda.Leave += new System.EventHandler(this.txtIdVenda_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nº Boleto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Venda";
            // 
            // dgFinanceiro
            // 
            this.dgFinanceiro.AllowUserToAddRows = false;
            this.dgFinanceiro.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.AliceBlue;
            this.dgFinanceiro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgFinanceiro.BackgroundColor = System.Drawing.Color.White;
            this.dgFinanceiro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgFinanceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFinanceiro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVenda,
            this.IdBoleto,
            this.Vencimento,
            this.Parcela,
            this.Cliente,
            this.REFERENCIA,
            this.Valor,
            this.Desc,
            this.Juros,
            this.Multas,
            this.Total,
            this.Pagou,
            this.TipoPgt,
            this.DiasVencidos});
            this.dgFinanceiro.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgFinanceiro.GridColor = System.Drawing.Color.Black;
            this.dgFinanceiro.Location = new System.Drawing.Point(12, 183);
            this.dgFinanceiro.Name = "dgFinanceiro";
            this.dgFinanceiro.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFinanceiro.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgFinanceiro.RowHeadersWidth = 10;
            this.dgFinanceiro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFinanceiro.Size = new System.Drawing.Size(1240, 465);
            this.dgFinanceiro.TabIndex = 1;
            this.dgFinanceiro.TabStop = false;
            this.dgFinanceiro.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgFinanceiro_CellFormatting);
            this.dgFinanceiro.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgFinanceiro_ColumnHeaderMouseClick);
            this.dgFinanceiro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgFinanceiro_KeyDown);
            // 
            // IdVenda
            // 
            this.IdVenda.DataPropertyName = "REFERENCIA_ID";
            this.IdVenda.HeaderText = "Venda";
            this.IdVenda.Name = "IdVenda";
            this.IdVenda.ReadOnly = true;
            this.IdVenda.Width = 75;
            // 
            // IdBoleto
            // 
            this.IdBoleto.DataPropertyName = "FINANCEIRO_ID";
            this.IdBoleto.HeaderText = "Boleto";
            this.IdBoleto.Name = "IdBoleto";
            this.IdBoleto.ReadOnly = true;
            this.IdBoleto.Width = 75;
            // 
            // Vencimento
            // 
            this.Vencimento.DataPropertyName = "VENCIMENTO";
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.ReadOnly = true;
            // 
            // Parcela
            // 
            this.Parcela.DataPropertyName = "NUM_PARCELA";
            this.Parcela.HeaderText = "Parcela";
            this.Parcela.Name = "Parcela";
            this.Parcela.ReadOnly = true;
            this.Parcela.Visible = false;
            this.Parcela.Width = 90;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "NOME";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 280;
            // 
            // REFERENCIA
            // 
            this.REFERENCIA.DataPropertyName = "REFERENCIA";
            this.REFERENCIA.HeaderText = "Referência";
            this.REFERENCIA.Name = "REFERENCIA";
            this.REFERENCIA.ReadOnly = true;
            this.REFERENCIA.Width = 130;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "VALOR";
            dataGridViewCellStyle10.Format = "c";
            this.Valor.DefaultCellStyle = dataGridViewCellStyle10;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Desc
            // 
            this.Desc.DataPropertyName = "DESCONTO";
            dataGridViewCellStyle11.Format = "c";
            this.Desc.DefaultCellStyle = dataGridViewCellStyle11;
            this.Desc.HeaderText = "Desconto";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            this.Desc.Width = 80;
            // 
            // Juros
            // 
            this.Juros.DataPropertyName = "JURO";
            dataGridViewCellStyle12.Format = "c";
            this.Juros.DefaultCellStyle = dataGridViewCellStyle12;
            this.Juros.HeaderText = "Juros";
            this.Juros.Name = "Juros";
            this.Juros.ReadOnly = true;
            this.Juros.Width = 80;
            // 
            // Multas
            // 
            this.Multas.DataPropertyName = "MULTA";
            dataGridViewCellStyle13.Format = "c";
            this.Multas.DefaultCellStyle = dataGridViewCellStyle13;
            this.Multas.HeaderText = "Multas";
            this.Multas.Name = "Multas";
            this.Multas.ReadOnly = true;
            this.Multas.Width = 80;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "TOTAL";
            dataGridViewCellStyle14.Format = "c";
            this.Total.DefaultCellStyle = dataGridViewCellStyle14;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Pagou
            // 
            this.Pagou.DataPropertyName = "DATA_PAGOU";
            dataGridViewCellStyle15.Format = "d";
            this.Pagou.DefaultCellStyle = dataGridViewCellStyle15;
            this.Pagou.HeaderText = "Pagou";
            this.Pagou.Name = "Pagou";
            this.Pagou.ReadOnly = true;
            this.Pagou.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pagou.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TipoPgt
            // 
            this.TipoPgt.DataPropertyName = "TIPO_PGT";
            this.TipoPgt.HeaderText = "Tipo Pgt";
            this.TipoPgt.Name = "TipoPgt";
            this.TipoPgt.ReadOnly = true;
            // 
            // DiasVencidos
            // 
            this.DiasVencidos.DataPropertyName = "Dias_Vencidos";
            this.DiasVencidos.HeaderText = "Dias Vencidos";
            this.DiasVencidos.Name = "DiasVencidos";
            this.DiasVencidos.ReadOnly = true;
            this.DiasVencidos.Visible = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lblVencidos);
            this.groupBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox10.Location = new System.Drawing.Point(476, 115);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(136, 56);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "R$ Vencido";
            // 
            // lblVencidos
            // 
            this.lblVencidos.Location = new System.Drawing.Point(6, 19);
            this.lblVencidos.Name = "lblVencidos";
            this.lblVencidos.Size = new System.Drawing.Size(124, 34);
            this.lblVencidos.TabIndex = 0;
            this.lblVencidos.Text = "R$ 0,00";
            this.lblVencidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(881, 655);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cores da Lista:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(1018, 657);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 15);
            this.label9.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(1044, 655);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Não Pagos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(1173, 655);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Vencidos";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(1147, 657);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 15);
            this.label12.TabIndex = 5;
            // 
            // frmFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgFinanceiro);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmFinanceiro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financeiro";
            this.Load += new System.EventHandler(this.frmFinanceiro_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFinanceiro)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controles.dg dgFinanceiro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTotalGeral;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTotalRecebido;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblFaltaReceber;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblTotalCredito;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblTotalDebito;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblTotalCheque;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lblTotalDinheiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBoleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Multas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagou;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPgt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasVencidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btBuscar;
        private Controles.cbCombo cbTipoPagamento;
        private System.Windows.Forms.CheckBox ckTodos;
        private System.Windows.Forms.CheckBox ckNaoPago;
        private System.Windows.Forms.CheckBox ckPago;
        private System.Windows.Forms.CheckBox ckVencidos;
        private System.Windows.Forms.DateTimePicker txtData;
        private Controles.cbCombo cbProduto;
        private Controles.cbCombo cbCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controles.txtNumero txIdBoleto;
        private Controles.txtNumero txtIdVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label lblVencidos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}