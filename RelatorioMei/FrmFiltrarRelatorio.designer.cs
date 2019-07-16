namespace RelatorioMei
{
    partial class FrmFiltrarRelatorio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAnoApuracao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbMes = new System.Windows.Forms.RadioButton();
            this.rbAno = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPeriodo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por mês";
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPeriodo.ForeColor = System.Drawing.Color.Black;
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbPeriodo.Location = new System.Drawing.Point(25, 43);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(121, 27);
            this.cbPeriodo.TabIndex = 20;
            this.cbPeriodo.SelectedIndexChanged += new System.EventHandler(this.cbPeriodo_SelectedIndexChanged);
            this.cbPeriodo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbPeriodo_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Período de apuração";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(12, 176);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(399, 38);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAnoApuracao);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(214, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 90);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por ano";
            // 
            // txtAnoApuracao
            // 
            this.txtAnoApuracao.Location = new System.Drawing.Point(49, 44);
            this.txtAnoApuracao.MaxLength = 4;
            this.txtAnoApuracao.Name = "txtAnoApuracao";
            this.txtAnoApuracao.Size = new System.Drawing.Size(68, 26);
            this.txtAnoApuracao.TabIndex = 23;
            this.txtAnoApuracao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAnoApuracao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnoApuracao_KeyDown);
            this.txtAnoApuracao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnoApuracao_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ano da apuração";
            // 
            // rbMes
            // 
            this.rbMes.AutoSize = true;
            this.rbMes.ForeColor = System.Drawing.Color.White;
            this.rbMes.Location = new System.Drawing.Point(65, 33);
            this.rbMes.Name = "rbMes";
            this.rbMes.Size = new System.Drawing.Size(116, 23);
            this.rbMes.TabIndex = 24;
            this.rbMes.TabStop = true;
            this.rbMes.Text = "Filtrar por mês";
            this.rbMes.UseVisualStyleBackColor = true;
            // 
            // rbAno
            // 
            this.rbAno.AutoSize = true;
            this.rbAno.ForeColor = System.Drawing.Color.White;
            this.rbAno.Location = new System.Drawing.Point(214, 33);
            this.rbAno.Name = "rbAno";
            this.rbAno.Size = new System.Drawing.Size(114, 23);
            this.rbAno.TabIndex = 25;
            this.rbAno.TabStop = true;
            this.rbAno.Text = "Filtrar por ano";
            this.rbAno.UseVisualStyleBackColor = true;
            this.rbAno.CheckedChanged += new System.EventHandler(this.rbAno_CheckedChanged);
            // 
            // FrmFiltrarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(428, 233);
            this.Controls.Add(this.rbAno);
            this.Controls.Add(this.rbMes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFiltrarRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPeriodo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAnoApuracao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMes;
        private System.Windows.Forms.RadioButton rbAno;
    }
}