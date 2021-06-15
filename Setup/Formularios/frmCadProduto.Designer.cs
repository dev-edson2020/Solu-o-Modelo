
namespace Setup.Formularios
{
    partial class frmCadProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadProduto));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CkAtivo = new System.Windows.Forms.CheckBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.BotaoAddFoto = new System.Windows.Forms.Button();
            this.BotaoUltima = new System.Windows.Forms.Button();
            this.BotaoProxima = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.BotaoAnterior = new System.Windows.Forms.Button();
            this.BotaoPrimeira = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbProduto = new Setup.Controles.cbCombo();
            this.txtCodigo = new Setup.Controles.txt();
            this.txtCodBarra = new Setup.Controles.txt();
            this.txtValidade = new Setup.Controles.txtDataLeave();
            this.txtCusto = new Setup.Controles.Moeda();
            this.txtReajuste = new Setup.Controles.txtNumero();
            this.txtVenda = new Setup.Controles.Moeda();
            this.txtEstoque = new Setup.Controles.txtNumero();
            this.txtEstMinimo = new Setup.Controles.txtNumero();
            this.txtCadastro = new Setup.Controles.txt();
            this.FotoProduto = new System.Windows.Forms.PictureBox();
            this.txtFotoId = new Setup.Controles.txt();
            this.txtId = new Setup.Controles.txt();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CkAtivo
            // 
            this.CkAtivo.AutoSize = true;
            this.CkAtivo.Checked = true;
            this.CkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CkAtivo.Location = new System.Drawing.Point(283, 236);
            this.CkAtivo.Name = "CkAtivo";
            this.CkAtivo.Size = new System.Drawing.Size(50, 17);
            this.CkAtivo.TabIndex = 14;
            this.CkAtivo.Text = "Ativo";
            this.CkAtivo.UseVisualStyleBackColor = true;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btNovo.FlatAppearance.BorderSize = 0;
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovo.ForeColor = System.Drawing.Color.White;
            this.btNovo.Location = new System.Drawing.Point(274, 291);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(122, 37);
            this.btNovo.TabIndex = 13;
            this.btNovo.Text = "Novo Registro";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.ForeColor = System.Drawing.Color.White;
            this.btSalvar.Location = new System.Drawing.Point(119, 291);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(122, 37);
            this.btSalvar.TabIndex = 13;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // BotaoAddFoto
            // 
            this.BotaoAddFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BotaoAddFoto.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoAddFoto.Location = new System.Drawing.Point(693, 268);
            this.BotaoAddFoto.Name = "BotaoAddFoto";
            this.BotaoAddFoto.Size = new System.Drawing.Size(28, 23);
            this.BotaoAddFoto.TabIndex = 12;
            this.BotaoAddFoto.Text = "+";
            this.BotaoAddFoto.UseVisualStyleBackColor = false;
            this.BotaoAddFoto.Click += new System.EventHandler(this.BotaoAddFoto_Click);
            // 
            // BotaoUltima
            // 
            this.BotaoUltima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BotaoUltima.Enabled = false;
            this.BotaoUltima.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoUltima.Location = new System.Drawing.Point(650, 268);
            this.BotaoUltima.Name = "BotaoUltima";
            this.BotaoUltima.Size = new System.Drawing.Size(35, 23);
            this.BotaoUltima.TabIndex = 12;
            this.BotaoUltima.Text = ">>";
            this.BotaoUltima.UseVisualStyleBackColor = false;
            // 
            // BotaoProxima
            // 
            this.BotaoProxima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BotaoProxima.Enabled = false;
            this.BotaoProxima.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoProxima.Location = new System.Drawing.Point(609, 268);
            this.BotaoProxima.Name = "BotaoProxima";
            this.BotaoProxima.Size = new System.Drawing.Size(35, 23);
            this.BotaoProxima.TabIndex = 12;
            this.BotaoProxima.Text = ">";
            this.BotaoProxima.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(800, 26);
            this.label12.TabIndex = 8;
            this.label12.Text = "CADASTRO DE PRODUTOS";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BotaoAnterior
            // 
            this.BotaoAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BotaoAnterior.Enabled = false;
            this.BotaoAnterior.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoAnterior.Location = new System.Drawing.Point(568, 268);
            this.BotaoAnterior.Name = "BotaoAnterior";
            this.BotaoAnterior.Size = new System.Drawing.Size(35, 23);
            this.BotaoAnterior.TabIndex = 12;
            this.BotaoAnterior.Text = "<";
            this.BotaoAnterior.UseVisualStyleBackColor = false;
            // 
            // BotaoPrimeira
            // 
            this.BotaoPrimeira.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BotaoPrimeira.Enabled = false;
            this.BotaoPrimeira.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoPrimeira.Location = new System.Drawing.Point(527, 268);
            this.BotaoPrimeira.Name = "BotaoPrimeira";
            this.BotaoPrimeira.Size = new System.Drawing.Size(35, 23);
            this.BotaoPrimeira.TabIndex = 12;
            this.BotaoPrimeira.Text = "<<";
            this.BotaoPrimeira.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbProduto);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.txtCodBarra);
            this.panel1.Controls.Add(this.txtValidade);
            this.panel1.Controls.Add(this.txtCusto);
            this.panel1.Controls.Add(this.txtReajuste);
            this.panel1.Controls.Add(this.txtVenda);
            this.panel1.Controls.Add(this.txtEstoque);
            this.panel1.Controls.Add(this.txtEstMinimo);
            this.panel1.Controls.Add(this.txtCadastro);
            this.panel1.Controls.Add(this.CkAtivo);
            this.panel1.Controls.Add(this.btNovo);
            this.panel1.Controls.Add(this.btSalvar);
            this.panel1.Controls.Add(this.BotaoAddFoto);
            this.panel1.Controls.Add(this.BotaoUltima);
            this.panel1.Controls.Add(this.BotaoProxima);
            this.panel1.Controls.Add(this.BotaoAnterior);
            this.panel1.Controls.Add(this.BotaoPrimeira);
            this.panel1.Controls.Add(this.FotoProduto);
            this.panel1.Controls.Add(this.txtFotoId);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 333);
            this.panel1.TabIndex = 7;
            // 
            // cbProduto
            // 
            this.cbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProduto.DisplayMember = "NOME";
            this.cbProduto.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(25, 55);
            this.cbProduto.MaxLength = 80;
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(332, 23);
            this.cbProduto.TabIndex = 1;
            this.cbProduto.Tag = "Descrição do Produto";
            this.cbProduto.ValueMember = "NOME";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigo.Location = new System.Drawing.Point(373, 55);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.Tag = "";
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodBarra.Location = new System.Drawing.Point(25, 112);
            this.txtCodBarra.MaxLength = 44;
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.Size = new System.Drawing.Size(448, 23);
            this.txtCodBarra.TabIndex = 3;
            this.txtCodBarra.Enter += new System.EventHandler(this.txtCodBarra_Enter);
            // 
            // txtValidade
            // 
            this.txtValidade.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValidade.Location = new System.Drawing.Point(25, 173);
            this.txtValidade.Name = "txtValidade";
            this.txtValidade.Size = new System.Drawing.Size(100, 23);
            this.txtValidade.TabIndex = 4;
            this.txtValidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCusto
            // 
            this.txtCusto.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCusto.Location = new System.Drawing.Point(141, 173);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(100, 23);
            this.txtCusto.TabIndex = 5;
            this.txtCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCusto.TextChanged += new System.EventHandler(this.txtCusto_TextChanged);
            // 
            // txtReajuste
            // 
            this.txtReajuste.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReajuste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtReajuste.Location = new System.Drawing.Point(257, 173);
            this.txtReajuste.Name = "txtReajuste";
            this.txtReajuste.Size = new System.Drawing.Size(100, 23);
            this.txtReajuste.TabIndex = 6;
            this.txtReajuste.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtReajuste.TextChanged += new System.EventHandler(this.txtReajuste_TextChanged);
            // 
            // txtVenda
            // 
            this.txtVenda.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVenda.Location = new System.Drawing.Point(373, 173);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(100, 23);
            this.txtVenda.TabIndex = 7;
            this.txtVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEstoque.Location = new System.Drawing.Point(25, 236);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(100, 23);
            this.txtEstoque.TabIndex = 8;
            this.txtEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEstMinimo
            // 
            this.txtEstMinimo.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstMinimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEstMinimo.Location = new System.Drawing.Point(156, 236);
            this.txtEstMinimo.Name = "txtEstMinimo";
            this.txtEstMinimo.Size = new System.Drawing.Size(100, 23);
            this.txtEstMinimo.TabIndex = 9;
            this.txtEstMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCadastro
            // 
            this.txtCadastro.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCadastro.Location = new System.Drawing.Point(373, 236);
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.ReadOnly = true;
            this.txtCadastro.Size = new System.Drawing.Size(100, 23);
            this.txtCadastro.TabIndex = 10;
            // 
            // FotoProduto
            // 
            this.FotoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoProduto.Location = new System.Drawing.Point(527, 39);
            this.FotoProduto.Name = "FotoProduto";
            this.FotoProduto.Size = new System.Drawing.Size(194, 224);
            this.FotoProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoProduto.TabIndex = 11;
            this.FotoProduto.TabStop = false;
            // 
            // txtFotoId
            // 
            this.txtFotoId.BackColor = System.Drawing.Color.Yellow;
            this.txtFotoId.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFotoId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFotoId.Location = new System.Drawing.Point(652, 10);
            this.txtFotoId.Name = "txtFotoId";
            this.txtFotoId.ReadOnly = true;
            this.txtFotoId.Size = new System.Drawing.Size(60, 23);
            this.txtFotoId.TabIndex = 10;
            this.txtFotoId.Visible = false;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Yellow;
            this.txtId.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.Location = new System.Drawing.Point(25, 9);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(63, 23);
            this.txtId.TabIndex = 10;
            this.txtId.Visible = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(504, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1, 290);
            this.label11.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "% Reajuste";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "R$ Venda";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(370, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cadastro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(153, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Est. Minimo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Estoque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "R$ Custo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Validade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código de Barras";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição do Produto";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(766, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(32, 26);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmCadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadProduto";
            this.Load += new System.EventHandler(this.frmCadProduto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadProduto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private Controles.cbCombo cbProduto;
        private Controles.txt txtCodigo;
        private Controles.txt txtCodBarra;
        private Controles.txtDataLeave txtValidade;
        private Controles.Moeda txtCusto;
        private Controles.txtNumero txtReajuste;
        private Controles.Moeda txtVenda;
        private Controles.txtNumero txtEstoque;
        private Controles.txtNumero txtEstMinimo;
        private Controles.txt txtCadastro;
        private System.Windows.Forms.CheckBox CkAtivo;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button BotaoAddFoto;
        private System.Windows.Forms.Button BotaoUltima;
        private System.Windows.Forms.Button BotaoProxima;
        private System.Windows.Forms.Button BotaoAnterior;
        private System.Windows.Forms.Button BotaoPrimeira;
        private System.Windows.Forms.PictureBox FotoProduto;
        private Controles.txt txtFotoId;
        public Controles.txt txtId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
    }
}