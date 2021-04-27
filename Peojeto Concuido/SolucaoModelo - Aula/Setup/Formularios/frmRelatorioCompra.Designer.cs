namespace Setup.Formularios
{
    partial class frmRelatorioCompra
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
            this.grGeral = new System.Windows.Forms.GroupBox();
            this.opExcel1 = new System.Windows.Forms.RadioButton();
            this.opPDF1 = new System.Windows.Forms.RadioButton();
            this.btGerarPeriodo = new System.Windows.Forms.Button();
            this.txtDataF1 = new Setup.Controles.txtDataLeave();
            this.txtDataI1 = new Setup.Controles.txtDataLeave();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFornecedor = new Setup.Controles.cbCombo();
            this.opExcel2 = new System.Windows.Forms.RadioButton();
            this.opPDF2 = new System.Windows.Forms.RadioButton();
            this.btGerarFornecedor = new System.Windows.Forms.Button();
            this.txtDataF2 = new Setup.Controles.txtDataLeave();
            this.txtDataI2 = new Setup.Controles.txtDataLeave();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbProduto = new Setup.Controles.cbCombo();
            this.opExcel3 = new System.Windows.Forms.RadioButton();
            this.opPDF3 = new System.Windows.Forms.RadioButton();
            this.btGerarProduto = new System.Windows.Forms.Button();
            this.txtDataF3 = new Setup.Controles.txtDataLeave();
            this.txtDataI3 = new Setup.Controles.txtDataLeave();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grGeral.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grGeral
            // 
            this.grGeral.Controls.Add(this.opExcel1);
            this.grGeral.Controls.Add(this.opPDF1);
            this.grGeral.Controls.Add(this.btGerarPeriodo);
            this.grGeral.Controls.Add(this.txtDataF1);
            this.grGeral.Controls.Add(this.txtDataI1);
            this.grGeral.Controls.Add(this.label2);
            this.grGeral.Controls.Add(this.label1);
            this.grGeral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grGeral.Location = new System.Drawing.Point(17, 19);
            this.grGeral.Margin = new System.Windows.Forms.Padding(4);
            this.grGeral.Name = "grGeral";
            this.grGeral.Padding = new System.Windows.Forms.Padding(4);
            this.grGeral.Size = new System.Drawing.Size(674, 86);
            this.grGeral.TabIndex = 0;
            this.grGeral.TabStop = false;
            this.grGeral.Text = "Compras por Período";
            // 
            // opExcel1
            // 
            this.opExcel1.AutoSize = true;
            this.opExcel1.Location = new System.Drawing.Point(498, 36);
            this.opExcel1.Name = "opExcel1";
            this.opExcel1.Size = new System.Drawing.Size(66, 21);
            this.opExcel1.TabIndex = 4;
            this.opExcel1.Text = "Excel";
            this.opExcel1.UseVisualStyleBackColor = true;
            // 
            // opPDF1
            // 
            this.opPDF1.AutoSize = true;
            this.opPDF1.Checked = true;
            this.opPDF1.Location = new System.Drawing.Point(442, 36);
            this.opPDF1.Name = "opPDF1";
            this.opPDF1.Size = new System.Drawing.Size(50, 21);
            this.opPDF1.TabIndex = 4;
            this.opPDF1.TabStop = true;
            this.opPDF1.Text = "PDF";
            this.opPDF1.UseVisualStyleBackColor = true;
            // 
            // btGerarPeriodo
            // 
            this.btGerarPeriodo.Location = new System.Drawing.Point(589, 28);
            this.btGerarPeriodo.Name = "btGerarPeriodo";
            this.btGerarPeriodo.Size = new System.Drawing.Size(67, 36);
            this.btGerarPeriodo.TabIndex = 3;
            this.btGerarPeriodo.Text = "Gerar";
            this.btGerarPeriodo.UseVisualStyleBackColor = true;
            this.btGerarPeriodo.Click += new System.EventHandler(this.btGerarPeriodo_Click);
            // 
            // txtDataF1
            // 
            this.txtDataF1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataF1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDataF1.Location = new System.Drawing.Point(334, 36);
            this.txtDataF1.Name = "txtDataF1";
            this.txtDataF1.Size = new System.Drawing.Size(100, 23);
            this.txtDataF1.TabIndex = 2;
            this.txtDataF1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDataI1
            // 
            this.txtDataI1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataI1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDataI1.Location = new System.Drawing.Point(177, 36);
            this.txtDataI1.Name = "txtDataI1";
            this.txtDataI1.Size = new System.Drawing.Size(100, 23);
            this.txtDataI1.TabIndex = 1;
            this.txtDataI1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "até";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o Período";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFornecedor);
            this.groupBox1.Controls.Add(this.opExcel2);
            this.groupBox1.Controls.Add(this.opPDF2);
            this.groupBox1.Controls.Add(this.btGerarFornecedor);
            this.groupBox1.Controls.Add(this.txtDataF2);
            this.groupBox1.Controls.Add(this.txtDataI2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(17, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(674, 86);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compras por Fornecedor";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFornecedor.DisplayMember = "NOME";
            this.cbFornecedor.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(253, 44);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(162, 23);
            this.cbFornecedor.TabIndex = 7;
            this.cbFornecedor.ValueMember = "PESSOA_ID";
            // 
            // opExcel2
            // 
            this.opExcel2.AutoSize = true;
            this.opExcel2.Location = new System.Drawing.Point(498, 44);
            this.opExcel2.Name = "opExcel2";
            this.opExcel2.Size = new System.Drawing.Size(66, 21);
            this.opExcel2.TabIndex = 4;
            this.opExcel2.Text = "Excel";
            this.opExcel2.UseVisualStyleBackColor = true;
            // 
            // opPDF2
            // 
            this.opPDF2.AutoSize = true;
            this.opPDF2.Checked = true;
            this.opPDF2.Location = new System.Drawing.Point(442, 44);
            this.opPDF2.Name = "opPDF2";
            this.opPDF2.Size = new System.Drawing.Size(50, 21);
            this.opPDF2.TabIndex = 4;
            this.opPDF2.TabStop = true;
            this.opPDF2.Text = "PDF";
            this.opPDF2.UseVisualStyleBackColor = true;
            // 
            // btGerarFornecedor
            // 
            this.btGerarFornecedor.Location = new System.Drawing.Point(589, 28);
            this.btGerarFornecedor.Name = "btGerarFornecedor";
            this.btGerarFornecedor.Size = new System.Drawing.Size(67, 36);
            this.btGerarFornecedor.TabIndex = 8;
            this.btGerarFornecedor.Text = "Gerar";
            this.btGerarFornecedor.UseVisualStyleBackColor = true;
            this.btGerarFornecedor.Click += new System.EventHandler(this.btGerarFornecedor_Click);
            // 
            // txtDataF2
            // 
            this.txtDataF2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataF2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDataF2.Location = new System.Drawing.Point(144, 44);
            this.txtDataF2.Name = "txtDataF2";
            this.txtDataF2.Size = new System.Drawing.Size(100, 23);
            this.txtDataF2.TabIndex = 6;
            this.txtDataF2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDataI2
            // 
            this.txtDataI2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataI2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDataI2.Location = new System.Drawing.Point(7, 44);
            this.txtDataI2.Name = "txtDataI2";
            this.txtDataI2.Size = new System.Drawing.Size(100, 23);
            this.txtDataI2.TabIndex = 5;
            this.txtDataI2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(113, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "até";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(250, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fornecedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(80, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Informe o Período";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbProduto);
            this.groupBox2.Controls.Add(this.opExcel3);
            this.groupBox2.Controls.Add(this.opPDF3);
            this.groupBox2.Controls.Add(this.btGerarProduto);
            this.groupBox2.Controls.Add(this.txtDataF3);
            this.groupBox2.Controls.Add(this.txtDataI3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(17, 216);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(674, 86);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compras por Produto";
            // 
            // cbProduto
            // 
            this.cbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProduto.DisplayMember = "NOME";
            this.cbProduto.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(253, 44);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(162, 23);
            this.cbProduto.TabIndex = 12;
            this.cbProduto.ValueMember = "PRODUTO_ID";
            // 
            // opExcel3
            // 
            this.opExcel3.AutoSize = true;
            this.opExcel3.Location = new System.Drawing.Point(498, 44);
            this.opExcel3.Name = "opExcel3";
            this.opExcel3.Size = new System.Drawing.Size(66, 21);
            this.opExcel3.TabIndex = 4;
            this.opExcel3.Text = "Excel";
            this.opExcel3.UseVisualStyleBackColor = true;
            // 
            // opPDF3
            // 
            this.opPDF3.AutoSize = true;
            this.opPDF3.Checked = true;
            this.opPDF3.Location = new System.Drawing.Point(442, 44);
            this.opPDF3.Name = "opPDF3";
            this.opPDF3.Size = new System.Drawing.Size(50, 21);
            this.opPDF3.TabIndex = 4;
            this.opPDF3.TabStop = true;
            this.opPDF3.Text = "PDF";
            this.opPDF3.UseVisualStyleBackColor = true;
            // 
            // btGerarProduto
            // 
            this.btGerarProduto.Location = new System.Drawing.Point(589, 28);
            this.btGerarProduto.Name = "btGerarProduto";
            this.btGerarProduto.Size = new System.Drawing.Size(67, 36);
            this.btGerarProduto.TabIndex = 13;
            this.btGerarProduto.Text = "Gerar";
            this.btGerarProduto.UseVisualStyleBackColor = true;
            this.btGerarProduto.Click += new System.EventHandler(this.btGerarProduto_Click);
            // 
            // txtDataF3
            // 
            this.txtDataF3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataF3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDataF3.Location = new System.Drawing.Point(144, 44);
            this.txtDataF3.Name = "txtDataF3";
            this.txtDataF3.Size = new System.Drawing.Size(100, 23);
            this.txtDataF3.TabIndex = 11;
            this.txtDataF3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDataI3
            // 
            this.txtDataI3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataI3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDataI3.Location = new System.Drawing.Point(7, 44);
            this.txtDataI3.Name = "txtDataI3";
            this.txtDataI3.Size = new System.Drawing.Size(100, 23);
            this.txtDataI3.TabIndex = 10;
            this.txtDataI3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(113, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "até";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(250, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Produto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(80, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Informe o Período";
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 19;
            this.reportViewer1.Location = new System.Drawing.Point(577, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(23, 24);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Visible = false;
            // 
            // frmRelatorioCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 322);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grGeral);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(725, 361);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(725, 361);
            this.Name = "frmRelatorioCompra";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios de Compras";
            this.Load += new System.EventHandler(this.frmRelatorioCompra_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRelatorioCompra_KeyDown);
            this.grGeral.ResumeLayout(false);
            this.grGeral.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grGeral;
        private System.Windows.Forms.RadioButton opExcel1;
        private System.Windows.Forms.RadioButton opPDF1;
        private System.Windows.Forms.Button btGerarPeriodo;
        private Controles.txtDataLeave txtDataF1;
        private Controles.txtDataLeave txtDataI1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton opExcel2;
        private System.Windows.Forms.RadioButton opPDF2;
        private System.Windows.Forms.Button btGerarFornecedor;
        private Controles.txtDataLeave txtDataF2;
        private Controles.txtDataLeave txtDataI2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Controles.cbCombo cbFornecedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private Controles.cbCombo cbProduto;
        private System.Windows.Forms.RadioButton opExcel3;
        private System.Windows.Forms.RadioButton opPDF3;
        private System.Windows.Forms.Button btGerarProduto;
        private Controles.txtDataLeave txtDataF3;
        private Controles.txtDataLeave txtDataI3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}