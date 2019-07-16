using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RelatorioMei.Properties;

namespace RelatorioMei
{
    public partial class FrmAutenticacao : Form
    {
        public FrmAutenticacao()
        {
            InitializeComponent();
        }

        ClassUsuario Usuario = new ClassUsuario();

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenha.Text != "")
                {
                    Usuario._usuario = cbUsuario.Text;
                    Usuario._senha = ClassSecurityPassword.Pass(txtSenha.Text);
                    if (Usuario.Autenticar() == true)
                    {
                        this.Visible = false;
                        if (!string.IsNullOrEmpty(Settings.Default["Disco"].ToString()))
                        {
                            FrmTelaPrincipal telaInicial = new FrmTelaPrincipal();
                            telaInicial.ShowDialog();
                        }
                        else
                        {
                            FrmOpcaoDiretorio opcaoDiretorio = new FrmOpcaoDiretorio();
                            opcaoDiretorio.ShowDialog();
                            if (!string.IsNullOrEmpty(Settings.Default["Disco"].ToString()))
                            {
                                FrmTelaPrincipal telaInicial = new FrmTelaPrincipal();
                                telaInicial.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado! Verifique novamente a sua senha!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtSenha.Clear();
                        txtSenha.Focus();
                    }
                }
                else
                    MessageBox.Show("Digita a senha!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAutenticacao_Load(object sender, EventArgs e)
        {
            if (VerificarDataBase() == true)
            {
                if (VerificarUsuario() == true)
                {
                    InformarNomeUsuario();
                }
                else
                {
                    MessageBox.Show("Crie o usuário e senha.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmUsuario usuario = new FrmUsuario();
                    usuario.ShowDialog();
                    if (VerificarUsuario() == true)
                    {
                        InformarNomeUsuario();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Verificamos que não existe dados no banco de dados instalado em seu computador. É o seu primeiro acesso a este programa?", "Pergunta do sistema 'System RM'", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("Criaremos a base necessária para você proseguir", "Mensagem do sistema System RM", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CriarDataBase();
                    CriarTableRelatorio();
                    CriarTableUsuario();

                    MessageBox.Show("Crie o usuário e senha.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmUsuario usuario = new FrmUsuario();
                    usuario.ShowDialog();
                    if (VerificarUsuario() == true)
                    {
                        InformarNomeUsuario();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione o arquivo de backup para a restauração do sistema.", "Mensagem do sistema System RM", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "|*.bak";
                    openFileDialog.Title = "Abrir aqrquivo para restauração";

                    if (DialogResult.OK == openFileDialog.ShowDialog())
                    {

                        SqlConnection conexao = new SqlConnection(ClassSecurity.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHJjGrOXTsH7b9NW1qcCpVJxD4wsfhTDR6OXOUSfCqDynZ+0PYEaREWQ=="));
                        _sql = "Restore database dbRelatorioMei from disk = '" + openFileDialog.FileName + "'";
                        SqlCommand comando = new SqlCommand(_sql, conexao);
                        comando.CommandText = _sql;
                        try
                        {
                            conexao.Open();
                            comando.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conexao.Close();
                        }
                        InformarNomeUsuario();
                    }
                    else
                    {
                        MessageBox.Show("É necessário selecionar o arquivo de backup para restaurar o sistema. Reinicie o programa novamente.", "Aviso do sistema System RM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                }              
            }
        }

        private void InformarNomeUsuario()
        {
            SqlConnection conexao = new SqlConnection(ClassSecurity.Dry("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdHlL+EPQ/vbiEFWCzepyTvrf01bWpwKlUnEPjCx+FMNHo5c5RJ8KoPKdn7Q9gRpERZ"));
            _sql = "select Usuario from Usuario order by Usuario asc";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                cbUsuario.DataSource = Tabela;
                cbUsuario.DisplayMember = "Usuario";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }

        string  _sql;
        private void CriarDataBase()
        {
            SqlConnection conexao = new SqlConnection(ClassSecurity.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHJjGrOXTsH7b9NW1qcCpVJxD4wsfhTDR6OXOUSfCqDynZ+0PYEaREWQ=="));
            _sql = "create database dbRelatorioMei";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void CriarTableRelatorio()
        {
            SqlConnection conexao = new SqlConnection(ClassSecurity.Dry("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdHlL+EPQ/vbiEFWCzepyTvrf01bWpwKlUnEPjCx+FMNHo5c5RJ8KoPKdn7Q9gRpERZ"));
            _sql = "CREATE TABLE [dbo].[Relatorio] ([Id_Relatorio] INT IDENTITY (1, 1) NOT NULL," +
                " [RevendaMer_NF] DECIMAL (18, 2) NULL, [RevendaMer_SNF] DECIMAL (18, 2) NULL, " +
                "[RevendaMer_Total] DECIMAL (18, 2) NULL, [Servico_NF] DECIMAL (18, 2) NULL, " +
                "[Servico_SNF] DECIMAL (18, 2) NULL, [Servico_Total] DECIMAL (18, 2) NULL, " +
                "[VendaInd_NF] DECIMAL (18, 2) NULL, [VendaInd_SNF] DECIMAL (18, 2) NULL, " +
                "[VendaInd_Total] DECIMAL (18, 2) NULL, [TotalReceitas] DECIMAL (18, 2) NULL, " +
                "[periodoApuracao]  VARCHAR (20)    NULL, [AnoApuracao] VARCHAR (4) NULL," +
                " PRIMARY KEY CLUSTERED ([Id_Relatorio] ASC));";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void CriarTableUsuario()
        {
            SqlConnection conexao = new SqlConnection(ClassSecurity.Dry("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdHlL+EPQ/vbiEFWCzepyTvrf01bWpwKlUnEPjCx+FMNHo5c5RJ8KoPKdn7Q9gRpERZ"));
            _sql = "CREATE TABLE [dbo].[Usuario] ( [Id_Usuario] INT IDENTITY (1, 1) NOT NULL, " +
                "[Usuario]    VARCHAR (30)  NULL, [Senha] VARCHAR (MAX) NULL," +
                " PRIMARY KEY CLUSTERED ([Id_Usuario] ASC));";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private bool VerificarDataBase()
        {
            SqlConnection conexao = new SqlConnection(ClassSecurity.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHJjGrOXTsH7b9NW1qcCpVJxD4wsfhTDR6OXOUSfCqDynZ+0PYEaREWQ=="));
            _sql = "Select * from Sys.Databases where name = 'dbRelatorioMei'";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        private bool VerificarUsuario()
        {
            SqlConnection conexao = new SqlConnection(ClassSecurity.Dry("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdHlL+EPQ/vbiEFWCzepyTvrf01bWpwKlUnEPjCx+FMNHo5c5RJ8KoPKdn7Q9gRpERZ"));
            _sql = "Select * from Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void FrmAutenticacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
