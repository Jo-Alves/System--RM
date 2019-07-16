namespace RelatorioMei
{
    partial class FrmGerarRelatorio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerarRelatorio));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtValor6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtValor9 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValor8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValor7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtValor10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValor3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtValor2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtValor1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RECEITA BRUTA MENSAL – REVENDA DE MERCADORIAS (COMÉRCIO)";
            // 
            // txtValor3
            // 
            this.txtValor3.BackColor = System.Drawing.Color.White;
            this.txtValor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor3.ForeColor = System.Drawing.Color.Black;
            this.txtValor3.Location = new System.Drawing.Point(28, 194);
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.ReadOnly = true;
            this.txtValor3.Size = new System.Drawing.Size(120, 26);
            this.txtValor3.TabIndex = 3;
            this.txtValor3.Text = "0,00";
            this.txtValor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "III – Total das receitas com revenda de mercadorias (I + II) - R$";
            // 
            // txtValor2
            // 
            this.txtValor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor2.ForeColor = System.Drawing.Color.Black;
            this.txtValor2.Location = new System.Drawing.Point(28, 127);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(120, 26);
            this.txtValor2.TabIndex = 2;
            this.txtValor2.Text = "0,00";
            this.txtValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor2.TextChanged += new System.EventHandler(this.TxtValor2_TextChanged);
            this.txtValor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor2_KeyPress);
            this.txtValor2.Leave += new System.EventHandler(this.TxtValor2_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "II – Revenda de mercadorias com documento fiscal emitido - R$";
            // 
            // txtValor1
            // 
            this.txtValor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor1.ForeColor = System.Drawing.Color.Black;
            this.txtValor1.Location = new System.Drawing.Point(28, 68);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(120, 26);
            this.txtValor1.TabIndex = 1;
            this.txtValor1.Text = "0,00";
            this.txtValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor1.TextChanged += new System.EventHandler(this.TxtValor1_TextChanged);
            this.txtValor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor1_KeyPress);
            this.txtValor1.Leave += new System.EventHandler(this.TxtValor1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "I – Revenda de mercadorias com dispensa de emissão de documento fiscal - R$";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtValor6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtValor5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtValor4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(553, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 238);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RECEITA BRUTA MENSAL – VENDA DE PRODUTOS INDUSTRIALIZADOS (INDÚSTRIA)";
            // 
            // txtValor6
            // 
            this.txtValor6.BackColor = System.Drawing.Color.White;
            this.txtValor6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor6.ForeColor = System.Drawing.Color.Black;
            this.txtValor6.Location = new System.Drawing.Point(28, 194);
            this.txtValor6.Name = "txtValor6";
            this.txtValor6.ReadOnly = true;
            this.txtValor6.Size = new System.Drawing.Size(102, 26);
            this.txtValor6.TabIndex = 6;
            this.txtValor6.Text = "0,00";
            this.txtValor6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(478, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "VI – Total das receitas com venda de produtos industrializados (IV + V) - R$";
            // 
            // txtValor5
            // 
            this.txtValor5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor5.ForeColor = System.Drawing.Color.Black;
            this.txtValor5.Location = new System.Drawing.Point(28, 127);
            this.txtValor5.Name = "txtValor5";
            this.txtValor5.Size = new System.Drawing.Size(102, 26);
            this.txtValor5.TabIndex = 5;
            this.txtValor5.Text = "0,00";
            this.txtValor5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor5.TextChanged += new System.EventHandler(this.TxtValor5_TextChanged);
            this.txtValor5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor5_KeyPress);
            this.txtValor5.Leave += new System.EventHandler(this.TxtValor5_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(461, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "V – Venda de produtos industrializados com documento fiscal emitido - R$";
            // 
            // txtValor4
            // 
            this.txtValor4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor4.ForeColor = System.Drawing.Color.Black;
            this.txtValor4.Location = new System.Drawing.Point(28, 68);
            this.txtValor4.Name = "txtValor4";
            this.txtValor4.Size = new System.Drawing.Size(102, 26);
            this.txtValor4.TabIndex = 4;
            this.txtValor4.Text = "0,00";
            this.txtValor4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor4.TextChanged += new System.EventHandler(this.TxtValor4_TextChanged);
            this.txtValor4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor4_KeyPress);
            this.txtValor4.Leave += new System.EventHandler(this.TxtValor4_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(564, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "IV – Venda de produtos industrializados com dispensa de emissão de documento fisc" +
    "al - R$";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtValor9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtValor8);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtValor7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(12, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(605, 238);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RECEITA BRUTA MENSAL – PRESTAÇÃO DE SERVIÇOS ";
            // 
            // txtValor9
            // 
            this.txtValor9.BackColor = System.Drawing.Color.White;
            this.txtValor9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor9.ForeColor = System.Drawing.Color.Black;
            this.txtValor9.Location = new System.Drawing.Point(28, 194);
            this.txtValor9.Name = "txtValor9";
            this.txtValor9.ReadOnly = true;
            this.txtValor9.Size = new System.Drawing.Size(102, 26);
            this.txtValor9.TabIndex = 9;
            this.txtValor9.Text = "0,00";
            this.txtValor9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(389, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "IX – Total das receitas com prestação de serviços (VII + VIII)";
            // 
            // txtValor8
            // 
            this.txtValor8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor8.ForeColor = System.Drawing.Color.Black;
            this.txtValor8.Location = new System.Drawing.Point(28, 127);
            this.txtValor8.Name = "txtValor8";
            this.txtValor8.Size = new System.Drawing.Size(102, 26);
            this.txtValor8.TabIndex = 8;
            this.txtValor8.Text = "0,00";
            this.txtValor8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor8.TextChanged += new System.EventHandler(this.TxtValor8_TextChanged);
            this.txtValor8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor8_KeyPress);
            this.txtValor8.Leave += new System.EventHandler(this.TxtValor8_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(476, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "VIII – Receita com prestação de serviços com documento fiscal emitido - R$";
            // 
            // txtValor7
            // 
            this.txtValor7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor7.ForeColor = System.Drawing.Color.Black;
            this.txtValor7.Location = new System.Drawing.Point(28, 68);
            this.txtValor7.Name = "txtValor7";
            this.txtValor7.Size = new System.Drawing.Size(102, 26);
            this.txtValor7.TabIndex = 7;
            this.txtValor7.Text = "0,00";
            this.txtValor7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor7.TextChanged += new System.EventHandler(this.TxtValor7_TextChanged);
            this.txtValor7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor7_KeyPress);
            this.txtValor7.Leave += new System.EventHandler(this.TxtValor7_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(24, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(569, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "VII – Receita com prestação de serviços com dispensa de emissão de documento fisc" +
    "al - R$";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Location = new System.Drawing.Point(879, 426);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(289, 49);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Gerar Relatório e Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtValor10);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(647, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(520, 114);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RECEITA BRUTA MENSAL – PRESTAÇÃO DE SERVIÇOS ";
            // 
            // txtValor10
            // 
            this.txtValor10.BackColor = System.Drawing.Color.White;
            this.txtValor10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor10.ForeColor = System.Drawing.Color.Black;
            this.txtValor10.Location = new System.Drawing.Point(28, 68);
            this.txtValor10.Name = "txtValor10";
            this.txtValor10.ReadOnly = true;
            this.txtValor10.Size = new System.Drawing.Size(102, 26);
            this.txtValor10.TabIndex = 10;
            this.txtValor10.Text = "0,00";
            this.txtValor10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(24, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(387, 19);
            this.label12.TabIndex = 6;
            this.label12.Text = "X - Total geral das receitas brutas no mês (III + VI + IX) - R$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(633, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Período de apuração";
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.ItemHeight = 19;
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
            this.cbPeriodo.Location = new System.Drawing.Point(637, 438);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(121, 27);
            this.cbPeriodo.TabIndex = 14;
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.Color.White;
            this.txtAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAno.ForeColor = System.Drawing.Color.Black;
            this.txtAno.Location = new System.Drawing.Point(764, 438);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(102, 26);
            this.txtAno.TabIndex = 11;
            this.txtAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(775, 413);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "Ano";
            // 
            // FrmGerarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1180, 543);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.cbPeriodo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmGerarRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO MENSAL DAS RECEITAS BRUTAS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtValor3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtValor6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtValor9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValor8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValor7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtValor10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbPeriodo;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label11;
    }
}

