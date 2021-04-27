namespace Setup.Formularios
{
    partial class frmSituacao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSituacao));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgSituacao = new Setup.Controles.dg();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new Setup.Controles.txt();
            this.BtNovo = new System.Windows.Forms.Button();
            this.BtExcluir = new System.Windows.Forms.Button();
            this.BtAlterar = new System.Windows.Forms.Button();
            this.BtAdd = new System.Windows.Forms.Button();
            this.txtSituacao = new Setup.Controles.txt();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PADRAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSituacao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgSituacao);
            this.groupBox2.Location = new System.Drawing.Point(8, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 186);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // dgSituacao
            // 
            this.dgSituacao.AllowUserToAddRows = false;
            this.dgSituacao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgSituacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSituacao.BackgroundColor = System.Drawing.Color.White;
            this.dgSituacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSituacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSituacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Situacao,
            this.PADRAO});
            this.dgSituacao.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgSituacao.GridColor = System.Drawing.Color.Black;
            this.dgSituacao.Location = new System.Drawing.Point(11, 16);
            this.dgSituacao.Name = "dgSituacao";
            this.dgSituacao.ReadOnly = true;
            this.dgSituacao.RowHeadersWidth = 10;
            this.dgSituacao.Size = new System.Drawing.Size(407, 164);
            this.dgSituacao.TabIndex = 0;
            this.dgSituacao.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.BtNovo);
            this.groupBox1.Controls.Add(this.BtExcluir);
            this.groupBox1.Controls.Add(this.BtAlterar);
            this.groupBox1.Controls.Add(this.BtAdd);
            this.groupBox1.Controls.Add(this.txtSituacao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Yellow;
            this.txtId.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.Location = new System.Drawing.Point(218, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(40, 23);
            this.txtId.TabIndex = 11;
            this.txtId.Visible = false;
            // 
            // BtNovo
            // 
            this.BtNovo.Image = ((System.Drawing.Image)(resources.GetObject("BtNovo.Image")));
            this.BtNovo.Location = new System.Drawing.Point(384, 21);
            this.BtNovo.Name = "BtNovo";
            this.BtNovo.Size = new System.Drawing.Size(34, 33);
            this.BtNovo.TabIndex = 7;
            this.BtNovo.UseVisualStyleBackColor = true;
            this.BtNovo.Click += new System.EventHandler(this.BtNovo_Click);
            // 
            // BtExcluir
            // 
            this.BtExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BtExcluir.Image")));
            this.BtExcluir.Location = new System.Drawing.Point(344, 21);
            this.BtExcluir.Name = "BtExcluir";
            this.BtExcluir.Size = new System.Drawing.Size(34, 33);
            this.BtExcluir.TabIndex = 8;
            this.BtExcluir.UseVisualStyleBackColor = true;
            this.BtExcluir.Click += new System.EventHandler(this.BtExcluir_Click);
            // 
            // BtAlterar
            // 
            this.BtAlterar.Image = ((System.Drawing.Image)(resources.GetObject("BtAlterar.Image")));
            this.BtAlterar.Location = new System.Drawing.Point(304, 21);
            this.BtAlterar.Name = "BtAlterar";
            this.BtAlterar.Size = new System.Drawing.Size(34, 33);
            this.BtAlterar.TabIndex = 9;
            this.BtAlterar.UseVisualStyleBackColor = true;
            this.BtAlterar.Click += new System.EventHandler(this.BtAlterar_Click);
            // 
            // BtAdd
            // 
            this.BtAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtAdd.Image")));
            this.BtAdd.Location = new System.Drawing.Point(264, 21);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(34, 33);
            this.BtAdd.TabIndex = 10;
            this.BtAdd.UseVisualStyleBackColor = true;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // txtSituacao
            // 
            this.txtSituacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSituacao.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSituacao.Location = new System.Drawing.Point(6, 31);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(252, 23);
            this.txtSituacao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descreva a Situação";
            // 
            // id
            // 
            this.id.DataPropertyName = "SITUACAO_ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 80;
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "NOME";
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            this.Situacao.Width = 370;
            // 
            // PADRAO
            // 
            this.PADRAO.DataPropertyName = "PADRAO";
            this.PADRAO.HeaderText = "PADRAO";
            this.PADRAO.Name = "PADRAO";
            this.PADRAO.ReadOnly = true;
            this.PADRAO.Visible = false;
            // 
            // frmSituacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 281);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 320);
            this.Name = "frmSituacao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Situação";
            this.Load += new System.EventHandler(this.frmSituacao_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSituacao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private Controles.dg dgSituacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controles.txt txtId;
        private System.Windows.Forms.Button BtNovo;
        private System.Windows.Forms.Button BtExcluir;
        private System.Windows.Forms.Button BtAlterar;
        private System.Windows.Forms.Button BtAdd;
        private Controles.txt txtSituacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn PADRAO;
    }
}