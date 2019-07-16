namespace RelatorioMei
{
    partial class FrmDadosEmpreendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDadosEmpreendedor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mkCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtEmpreendedorIndividual = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Empreendedor Individual";
            // 
            // mkCNPJ
            // 
            this.mkCNPJ.Location = new System.Drawing.Point(31, 48);
            this.mkCNPJ.Mask = "00,000,000/0000-00";
            this.mkCNPJ.Name = "mkCNPJ";
            this.mkCNPJ.Size = new System.Drawing.Size(141, 26);
            this.mkCNPJ.TabIndex = 0;
            this.mkCNPJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mkCNPJ_MaskInputRejected);
            this.mkCNPJ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mkCNPJ_KeyDown);
            // 
            // txtEmpreendedorIndividual
            // 
            this.txtEmpreendedorIndividual.Location = new System.Drawing.Point(31, 131);
            this.txtEmpreendedorIndividual.Name = "txtEmpreendedorIndividual";
            this.txtEmpreendedorIndividual.Size = new System.Drawing.Size(444, 26);
            this.txtEmpreendedorIndividual.TabIndex = 1;
            this.txtEmpreendedorIndividual.TextChanged += new System.EventHandler(this.txtEmpreendedorIndividual_TextChanged);
            this.txtEmpreendedorIndividual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpreendedorIndividual_KeyDown);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(241, 319);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(234, 49);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(31, 207);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(444, 26);
            this.txtCidade.TabIndex = 2;
            this.txtCidade.TextChanged += new System.EventHandler(this.txtCidade_TextChanged);
            this.txtCidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCidade_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PE",
            "PI",
            "PB",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbEstado.Location = new System.Drawing.Point(31, 262);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 27);
            this.cbEstado.TabIndex = 19;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            this.cbEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbEstado_KeyDown);
            // 
            // FrmDadosEmpreendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(503, 380);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtEmpreendedorIndividual);
            this.Controls.Add(this.mkCNPJ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDadosEmpreendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados do Empreendedor";
            this.Load += new System.EventHandler(this.FrmDadosEmpreendedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mkCNPJ;
        private System.Windows.Forms.TextBox txtEmpreendedorIndividual;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEstado;
    }
}