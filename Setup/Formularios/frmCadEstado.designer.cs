namespace Setup.Formularios
{
    partial class frmCadEstado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadEstado));
            this.panelEstado = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgEstado = new System.Windows.Forms.DataGridView();
            this.ESTADO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIGLA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtSigla = new Setup.Controles.txt();
            this.txtEstado = new Setup.Controles.txt();
            this.txtIdEstado = new Setup.Controles.txt();
            this.panelEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEstado
            // 
            this.panelEstado.BackColor = System.Drawing.Color.Gainsboro;
            this.panelEstado.Controls.Add(this.label24);
            this.panelEstado.Controls.Add(this.btnNovo);
            this.panelEstado.Controls.Add(this.dgEstado);
            this.panelEstado.Controls.Add(this.txtSigla);
            this.panelEstado.Controls.Add(this.txtEstado);
            this.panelEstado.Controls.Add(this.label3);
            this.panelEstado.Controls.Add(this.label2);
            this.panelEstado.Controls.Add(this.txtIdEstado);
            this.panelEstado.Controls.Add(this.btnSalvar);
            this.panelEstado.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelEstado.Location = new System.Drawing.Point(42, 76);
            this.panelEstado.Name = "panelEstado";
            this.panelEstado.Size = new System.Drawing.Size(548, 325);
            this.panelEstado.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Gray;
            this.label24.Location = new System.Drawing.Point(52, 303);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(331, 13);
            this.label24.TabIndex = 10;
            this.label24.Text = "Selecione um item e tecle(Ctrl + E) - Alterar Registro";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNovo.Location = new System.Drawing.Point(52, 89);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(120, 30);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "Novo Registro";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Visible = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovoContato_Click);
            // 
            // dgEstado
            // 
            this.dgEstado.AllowUserToAddRows = false;
            this.dgEstado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgEstado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEstado.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ESTADO_ID,
            this.ESTADO,
            this.SIGLA});
            this.dgEstado.Location = new System.Drawing.Point(52, 134);
            this.dgEstado.Name = "dgEstado";
            this.dgEstado.ReadOnly = true;
            this.dgEstado.RowHeadersWidth = 10;
            this.dgEstado.Size = new System.Drawing.Size(432, 160);
            this.dgEstado.TabIndex = 8;
            this.dgEstado.TabStop = false;
            this.dgEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgEstado_KeyDown);
            // 
            // ESTADO_ID
            // 
            this.ESTADO_ID.DataPropertyName = "ESTADO_ID";
            this.ESTADO_ID.HeaderText = "ID";
            this.ESTADO_ID.Name = "ESTADO_ID";
            this.ESTADO_ID.ReadOnly = true;
            this.ESTADO_ID.Visible = false;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ESTADO.DefaultCellStyle = dataGridViewCellStyle2;
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Width = 340;
            // 
            // SIGLA
            // 
            this.SIGLA.DataPropertyName = "SIGLA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SIGLA.DefaultCellStyle = dataGridViewCellStyle3;
            this.SIGLA.HeaderText = "SIGLA";
            this.SIGLA.Name = "SIGLA";
            this.SIGLA.ReadOnly = true;
            this.SIGLA.Width = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sigla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do Estado";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Green;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.Location = new System.Drawing.Point(389, 89);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 30);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar os dados do Estado");
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Consolas", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(-5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "ESTADOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "FrameWork Edivam Cabral";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Black;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(569, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(44, 37);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtSigla
            // 
            this.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSigla.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSigla.Location = new System.Drawing.Point(384, 60);
            this.txtSigla.MaxLength = 2;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(100, 23);
            this.txtSigla.TabIndex = 0;
            this.txtSigla.Tag = "Sigla";
            this.txtSigla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEstado.Location = new System.Drawing.Point(52, 60);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(326, 23);
            this.txtEstado.TabIndex = 0;
            this.txtEstado.TabStop = false;
            this.txtEstado.Tag = "Nome do Estado";
            this.txtEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEstado_KeyDown);
            // 
            // txtIdEstado
            // 
            this.txtIdEstado.BackColor = System.Drawing.Color.Yellow;
            this.txtIdEstado.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdEstado.Location = new System.Drawing.Point(497, 3);
            this.txtIdEstado.Name = "txtIdEstado";
            this.txtIdEstado.Size = new System.Drawing.Size(48, 23);
            this.txtIdEstado.TabIndex = 4;
            this.txtIdEstado.Visible = false;
            // 
            // frmCadEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(625, 422);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.panelEstado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmCadEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadEstado";
            this.Load += new System.EventHandler(this.frmCadEstado_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadEstado_KeyDown);
            this.panelEstado.ResumeLayout(false);
            this.panelEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEstado;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Controles.txt txtSigla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Controles.txt txtIdEstado;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dgEstado;
        public Controles.txt txtEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIGLA;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label24;
    }
}