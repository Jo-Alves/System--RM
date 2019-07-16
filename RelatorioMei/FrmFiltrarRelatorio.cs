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

namespace RelatorioMei
{
    public partial class FrmFiltrarRelatorio : Form
    {
        public FrmFiltrarRelatorio()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rbMes.Checked || rbAno.Checked)
            {
                if (rbMes.Checked)
                {
                    if (cbPeriodo.SelectedIndex >= 0 && txtAnoApuracao.Text != "")
                    {

                        if (VerificarSomaRelatorioReceitaPeriodo() == true)
                        {
                            Cursor = Cursors.WaitCursor;
                            FrmBuscarSomaRelatorioReceitaPeriodo somaRelatorioReceitaPeriodo = new FrmBuscarSomaRelatorioReceitaPeriodo(cbPeriodo.Text, txtAnoApuracao.Text);
                            somaRelatorioReceitaPeriodo.ShowDialog();
                            Cursor = Cursors.Default;
                        }
                        else
                        {
                            MessageBox.Show("Não encontramos na base de dados o relatório referente ao período de " + cbPeriodo.Text + " do ano de " + txtAnoApuracao.Text + ". Tente outra opção", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (txtAnoApuracao.Text == "")
                    {
                        MessageBox.Show("Informe o ano de apuração", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtAnoApuracao.Focus();
                    }
                    else
                        MessageBox.Show("Selecione o período de apuração", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtAnoApuracao.Text))
                    {
                        if (VerificarSomaRelatorioReceita() == true)
                        {
                            Cursor = Cursors.WaitCursor;
                            FrmBuscarSomaRelatorioReceita somaRelatorioReceita = new FrmBuscarSomaRelatorioReceita(txtAnoApuracao.Text);
                            somaRelatorioReceita.ShowDialog();
                            Cursor = Cursors.Default;
                        }
                        else
                        {
                            MessageBox.Show("Não encontramos na base de dados o relatório referente ao ano de " + txtAnoApuracao.Text + ". Tente outra opção", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                        MessageBox.Show("Infome o ano!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Marque a opção para a filtragem do período de apuração!", "Mensagem do sistema System RM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public bool VerificarSomaRelatorioReceita()
        {
            SqlConnection conexao = new SqlConnection(ClassSecurity.Dry("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdHlL+EPQ/vbiEFWCzepyTvrf01bWpwKlUnEPjCx+FMNHo5c5RJ8KoPKdn7Q9gRpERZ"));
            string _sql = "SELECT SUM(RevendaMer_NF) AS RevendaMer_NF, SUM(RevendaMer_SNF) AS RevendaMer_SNF, SUM(RevendaMer_Total) AS RevendaMer_Total, SUM(Servico_NF) AS Servico_NF, SUM(Servico_SNF) AS Servico_SNF, SUM(Servico_Total) AS Servico_Total, SUM(VendaInd_NF) AS VendaInd_NF, SUM(VendaInd_SNF)AS VendaInd_SNF, SUM(VendaInd_Total) AS VendaInd_Total, SUM(TotalReceitas) AS TotalReceitas FROM Relatorio WHERE(AnoApuracao = @Ano)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Ano", txtAnoApuracao.Text);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if(comando.ExecuteScalar() != DBNull.Value)
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

        public bool VerificarSomaRelatorioReceitaPeriodo()
        {
            SqlConnection conexao = new SqlConnection(ClassSecurity.Dry("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdHlL+EPQ/vbiEFWCzepyTvrf01bWpwKlUnEPjCx+FMNHo5c5RJ8KoPKdn7Q9gRpERZ"));
            string _sql = "SELECT SUM(RevendaMer_NF) AS RevendaMer_NF, SUM(RevendaMer_SNF) AS RevendaMer_SNF, SUM(RevendaMer_Total) AS RevendaMer_Total, SUM(Servico_NF) AS Servico_NF, SUM(Servico_SNF) AS Servico_SNF, SUM(Servico_Total) AS Servico_Total, SUM(VendaInd_NF) AS VendaInd_NF, SUM(VendaInd_SNF)AS VendaInd_SNF, SUM(VendaInd_Total) AS VendaInd_Total, SUM(TotalReceitas) AS TotalReceitas FROM Relatorio WHERE (PeriodoApuracao = @Periodo) and (AnoApuracao = @Ano)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Periodo", cbPeriodo.Text);
            comando.Parameters.AddWithValue("@Ano", txtAnoApuracao.Text);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() != DBNull.Value)
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

        private void txtAnoApuracao_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbAno_CheckedChanged(object sender, EventArgs e)
        {
            cbPeriodo.SelectedIndex = -1;
            txtAnoApuracao.Focus();
        }

        private void cbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbAno.Checked)
            {
                cbPeriodo.SelectedIndex = -1;
            }
        }

        private void cbPeriodo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }

        private void txtAnoApuracao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }
    }
}
