namespace RelatorioMei
{
    partial class FrmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuOpcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarDadosDoEmpreendedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuEscolherDiretorio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ForeColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpcoes,
            this.cadastroToolStripMenuItem,
            this.menuRelatorio,
            this.menuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuOpcoes
            // 
            this.menuOpcoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditarDadosDoEmpreendedor,
            this.menuCalculadora,
            this.MenuEscolherDiretorio});
            this.menuOpcoes.Name = "menuOpcoes";
            this.menuOpcoes.Size = new System.Drawing.Size(59, 20);
            this.menuOpcoes.Text = "Opções";
            // 
            // menuEditarDadosDoEmpreendedor
            // 
            this.menuEditarDadosDoEmpreendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuEditarDadosDoEmpreendedor.ForeColor = System.Drawing.Color.White;
            this.menuEditarDadosDoEmpreendedor.Name = "menuEditarDadosDoEmpreendedor";
            this.menuEditarDadosDoEmpreendedor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuEditarDadosDoEmpreendedor.Size = new System.Drawing.Size(277, 22);
            this.menuEditarDadosDoEmpreendedor.Text = "Editar dados do empreendedor";
            this.menuEditarDadosDoEmpreendedor.Click += new System.EventHandler(this.MenuEditarDadosDoEmpreendedor_Click);
            // 
            // menuCalculadora
            // 
            this.menuCalculadora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuCalculadora.ForeColor = System.Drawing.Color.White;
            this.menuCalculadora.Name = "menuCalculadora";
            this.menuCalculadora.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.U)));
            this.menuCalculadora.Size = new System.Drawing.Size(277, 22);
            this.menuCalculadora.Text = "Usar calculadora";
            this.menuCalculadora.Click += new System.EventHandler(this.MenuCalculadora_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsuario});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // MenuUsuario
            // 
            this.MenuUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuUsuario.ForeColor = System.Drawing.Color.White;
            this.MenuUsuario.Name = "MenuUsuario";
            this.MenuUsuario.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.MenuUsuario.Size = new System.Drawing.Size(156, 22);
            this.MenuUsuario.Text = "Usuário";
            this.MenuUsuario.Click += new System.EventHandler(this.MenuUsuario_Click);
            // 
            // menuRelatorio
            // 
            this.menuRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarRelatórioToolStripMenuItem,
            this.buscarRelatórioToolStripMenuItem});
            this.menuRelatorio.Name = "menuRelatorio";
            this.menuRelatorio.Size = new System.Drawing.Size(66, 20);
            this.menuRelatorio.Text = "Relatório";
            // 
            // gerarRelatórioToolStripMenuItem
            // 
            this.gerarRelatórioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gerarRelatórioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gerarRelatórioToolStripMenuItem.Name = "gerarRelatórioToolStripMenuItem";
            this.gerarRelatórioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.gerarRelatórioToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.gerarRelatórioToolStripMenuItem.Text = "Gerar Relatório";
            this.gerarRelatórioToolStripMenuItem.Click += new System.EventHandler(this.GerarRelatórioToolStripMenuItem_Click);
            // 
            // buscarRelatórioToolStripMenuItem
            // 
            this.buscarRelatórioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buscarRelatórioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.buscarRelatórioToolStripMenuItem.Name = "buscarRelatórioToolStripMenuItem";
            this.buscarRelatórioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.buscarRelatórioToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.buscarRelatórioToolStripMenuItem.Text = "Buscar Relatório";
            this.buscarRelatórioToolStripMenuItem.Click += new System.EventHandler(this.BuscarRelatórioToolStripMenuItem_Click);
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::RelatorioMei.Properties.Resources.Mei;
            this.pictureBox1.Location = new System.Drawing.Point(120, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(681, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MenuEscolherDiretorio
            // 
            this.MenuEscolherDiretorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuEscolherDiretorio.ForeColor = System.Drawing.Color.White;
            this.MenuEscolherDiretorio.Name = "MenuEscolherDiretorio";
            this.MenuEscolherDiretorio.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.MenuEscolherDiretorio.Size = new System.Drawing.Size(277, 22);
            this.MenuEscolherDiretorio.Text = "Escolher Diretório";
            this.MenuEscolherDiretorio.Click += new System.EventHandler(this.MenuEscolherDiretorio_Click);
            // 
            // FrmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(944, 491);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO MENSAL DAS RECEITAS BRUTAS - Sistema Relatorio MEI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTelaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmTelaPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTelaPrincipal_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuOpcoes;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorio;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem buscarRelatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEditarDadosDoEmpreendedor;
        private System.Windows.Forms.ToolStripMenuItem menuCalculadora;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuario;
        private System.Windows.Forms.ToolStripMenuItem MenuEscolherDiretorio;
    }
}