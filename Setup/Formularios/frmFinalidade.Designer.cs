
namespace Setup.Formularios
{
    partial class frmFinalidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinalidade));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new Setup.Controles.txt();
            this.BtNovo = new System.Windows.Forms.Button();
            this.BtExcluir = new System.Windows.Forms.Button();
            this.BtAlterar = new System.Windows.Forms.Button();
            this.BtAdd = new System.Windows.Forms.Button();
            this.txtFinalidade = new Setup.Controles.txt();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgFinalidade = new Setup.Controles.dg();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PADRAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFinalidade)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.BtNovo);
            this.groupBox1.Controls.Add(this.BtExcluir);
            this.groupBox1.Controls.Add(this.BtAlterar);
            this.groupBox1.Controls.Add(this.BtAdd);
            this.groupBox1.Controls.Add(this.txtFinalidade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Yellow;
            this.txtId.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.Location = new System.Drawing.Point(216, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(40, 23);
            this.txtId.TabIndex = 11;
            this.txtId.Visible = false;
            // 
            // BtNovo
            // 
            this.BtNovo.Image = ((System.Drawing.Image)(resources.GetObject("BtNovo.Image")));
            this.BtNovo.Location = new System.Drawing.Point(397, 23);
            this.BtNovo.Name = "BtNovo";
            this.BtNovo.Size = new System.Drawing.Size(34, 33);
            this.BtNovo.TabIndex = 7;
            this.BtNovo.UseVisualStyleBackColor = true;
            // 
            // BtExcluir
            // 
            this.BtExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BtExcluir.Image")));
            this.BtExcluir.Location = new System.Drawing.Point(357, 23);
            this.BtExcluir.Name = "BtExcluir";
            this.BtExcluir.Size = new System.Drawing.Size(34, 33);
            this.BtExcluir.TabIndex = 8;
            this.BtExcluir.UseVisualStyleBackColor = true;
            this.BtExcluir.Click += new System.EventHandler(this.BtExcluir_Click);
            // 
            // BtAlterar
            // 
            this.BtAlterar.Image = ((System.Drawing.Image)(resources.GetObject("BtAlterar.Image")));
            this.BtAlterar.Location = new System.Drawing.Point(317, 23);
            this.BtAlterar.Name = "BtAlterar";
            this.BtAlterar.Size = new System.Drawing.Size(34, 33);
            this.BtAlterar.TabIndex = 9;
            this.BtAlterar.UseVisualStyleBackColor = true;
            this.BtAlterar.Click += new System.EventHandler(this.BtAlterar_Click);
            // 
            // BtAdd
            // 
            this.BtAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtAdd.Image")));
            this.BtAdd.Location = new System.Drawing.Point(277, 23);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(34, 33);
            this.BtAdd.TabIndex = 10;
            this.BtAdd.UseVisualStyleBackColor = true;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // txtFinalidade
            // 
            this.txtFinalidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFinalidade.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFinalidade.Location = new System.Drawing.Point(4, 31);
            this.txtFinalidade.Name = "txtFinalidade";
            this.txtFinalidade.Size = new System.Drawing.Size(252, 23);
            this.txtFinalidade.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descreva a Finalidade";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgFinalidade);
            this.groupBox2.Location = new System.Drawing.Point(6, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 183);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // dgFinalidade
            // 
            this.dgFinalidade.AllowUserToAddRows = false;
            this.dgFinalidade.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            this.dgFinalidade.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgFinalidade.BackgroundColor = System.Drawing.Color.White;
            this.dgFinalidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgFinalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFinalidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Finalidade,
            this.PADRAO});
            this.dgFinalidade.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgFinalidade.GridColor = System.Drawing.Color.Black;
            this.dgFinalidade.Location = new System.Drawing.Point(2, -8);
            this.dgFinalidade.Name = "dgFinalidade";
            this.dgFinalidade.ReadOnly = true;
            this.dgFinalidade.RowHeadersWidth = 10;
            this.dgFinalidade.Size = new System.Drawing.Size(427, 191);
            this.dgFinalidade.TabIndex = 0;
            this.dgFinalidade.TabStop = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "FINALIDADE_ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 80;
            // 
            // Finalidade
            // 
            this.Finalidade.DataPropertyName = "NOME";
            this.Finalidade.HeaderText = "Finalidade";
            this.Finalidade.Name = "Finalidade";
            this.Finalidade.ReadOnly = true;
            this.Finalidade.Width = 459;
            // 
            // PADRAO
            // 
            this.PADRAO.DataPropertyName = "PADRAO";
            this.PADRAO.HeaderText = "PADRAO";
            this.PADRAO.Name = "PADRAO";
            this.PADRAO.ReadOnly = true;
            this.PADRAO.Visible = false;
            // 
            // frmFinalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 281);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 320);
            this.Name = "frmFinalidade";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Finalidades";
            this.Load += new System.EventHandler(this.frmFinalidade_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFinalidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Controles.txt txtId;
        private System.Windows.Forms.Button BtNovo;
        private System.Windows.Forms.Button BtExcluir;
        private System.Windows.Forms.Button BtAlterar;
        private System.Windows.Forms.Button BtAdd;
        private Controles.txt txtFinalidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Controles.dg dgFinalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Finalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PADRAO;
    }
}