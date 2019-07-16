namespace RelatorioMei
{
    partial class FrmAutenticacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutenticacao));
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbUsuario
            // 
            this.cbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUsuario.ForeColor = System.Drawing.Color.Black;
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(38, 42);
            this.cbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cbUsuario.MaxLength = 30;
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(246, 27);
            this.cbUsuario.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(38, 103);
            this.txtSenha.MaxLength = 15;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(246, 26);
            this.txtSenha.TabIndex = 0;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Aqua;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(38, 153);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(246, 35);
            this.btnEntrar.TabIndex = 1;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // FrmAutenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(314, 209);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.cbUsuario);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAutenticacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticação do Usuário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAutenticacao_FormClosing);
            this.Load += new System.EventHandler(this.FrmAutenticacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}