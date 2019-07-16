using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RelatorioMei.Properties;

namespace RelatorioMei
{
    public partial class FrmTelaPrincipal : Form
    {
        public FrmTelaPrincipal()
        {
            InitializeComponent();
        }
        string stringConn = ClassSecurity.Dry("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdHlL+EPQ/vbiEFWCzepyTvrf01bWpwKlUnEPjCx+FMNHo5c5RJ8KoPKdn7Q9gRpERZ"), _sql;

        bool Fechar = false;
        private void FrmTelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Fechar == false)
            {
                DialogResult dr = MessageBox.Show("Deseja realizar o backup agora?", "Aviso do sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (dr == DialogResult.Yes)
                {
                    GerarBackup();
                    Fechar = true;
                    Application.Exit();                   

                }
                else if (dr == DialogResult.No)
                {
                    e.Cancel = false;
                    Fechar = true;
                    Application.Exit();                    
                }
                else
                {
                    e.Cancel = true;
                    Fechar = false;
                }
            }
        }

        private void FrmTelaPrincipal_Load(object sender, EventArgs e)
        {
            menuOpcoes.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            menuRelatorio.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        }

        private void MenuEditarDadosDoEmpreendedor_Click(object sender, EventArgs e)
        {
            FrmDadosEmpreendedor dadosEmpreendedor = new FrmDadosEmpreendedor();
            dadosEmpreendedor.ShowDialog();
        }

        private void GerarRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGerarRelatorio gerarRelatorio = new FrmGerarRelatorio();
            gerarRelatorio.ShowDialog();
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja realizar o backup agora?", "Aviso do sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (dr == DialogResult.Yes)
            {
                GerarBackup();
                Fechar = true;
                Application.Exit();
               
            }
            else if (dr == DialogResult.No)
            {
                Fechar = true;
                Application.Exit();
            }
        }

        string Pasta;
        private void CriarPasta()
        {
            Pasta = Settings.Default["Disco"].ToString() +  @"Gerenciamento Relatorio Mei\Seguranca\";
            if (!Directory.Exists(Pasta))
            {
                Directory.CreateDirectory(Pasta);
            }
        }

        private void GerarBackup()
        {
            CriarPasta();
            DateTime dt = DateTime.Now;
            string Data = dt.Day + "-" + dt.Month + "-"
                + dt.Year + " - " + dt.Hour + "_" + dt.Minute + "_" + dt.Second;

            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "backup database dbRelatorioMei to disk = '" + Pasta + "Backup de Segurança - "  + Data + @".bak'";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                this.Cursor = Cursors.WaitCursor;
                comando.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
                this.Cursor = Cursors.Default;
            }
        }

        private void MenuCalculadora_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("calc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFiltrarRelatorio filtrarRelatorio = new FrmFiltrarRelatorio();
            filtrarRelatorio.Show();
        }

        private void MenuUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            usuario.ShowDialog();
        }

        private void MenuEscolherDiretorio_Click(object sender, EventArgs e)
        {
            FrmOpcaoDiretorio opcaoDiretorio = new FrmOpcaoDiretorio();
            opcaoDiretorio.ShowDialog();
        }

        private void FrmTelaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MenuSair_Click(sender, e);
            }
        }
    }
}
