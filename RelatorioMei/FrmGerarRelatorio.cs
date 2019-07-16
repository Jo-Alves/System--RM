using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelatorioMei
{
    public partial class FrmGerarRelatorio : Form
    {
        public FrmGerarRelatorio()
        {
            InitializeComponent();
        }

        decimal Valor1, Valor2, valorTotal1, valorTotal2, valorTotal3, ValorTotalGeral;               
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtValor1_TextChanged(object sender, EventArgs e)
        {
            if (txtValor1.Text == "")
            {
                txtValor1.Text = "0,00";
            }
            else
            {
                Valor1 = decimal.Parse(txtValor1.Text);
                Valor2 = decimal.Parse(txtValor2.Text);
                ValorTotalGeral = Valor1 + Valor2;
                txtValor3.Text = ValorTotalGeral.ToString();
                valorTotal1 = decimal.Parse(txtValor3.Text);
                valorTotal2 = decimal.Parse(txtValor6.Text);
                valorTotal3 = decimal.Parse(txtValor9.Text);
                ValorTotalGeral = valorTotal1 + valorTotal2 + valorTotal3;
                txtValor10.Text = ValorTotalGeral.ToString();
            }
        }

        private void TxtValor2_TextChanged(object sender, EventArgs e)
        {
            if (txtValor2.Text == "")
            {
                txtValor2.Text = "0,00";
            }
            else
            {
                Valor1 = decimal.Parse(txtValor1.Text);
                Valor2 = decimal.Parse(txtValor2.Text);
                ValorTotalGeral = Valor1 + Valor2;
                txtValor3.Text = ValorTotalGeral.ToString();
                valorTotal1 = decimal.Parse(txtValor3.Text);
                valorTotal2 = decimal.Parse(txtValor6.Text);
                valorTotal3 = decimal.Parse(txtValor9.Text);
                ValorTotalGeral = valorTotal1 + valorTotal2 + valorTotal3;
                txtValor10.Text = ValorTotalGeral.ToString();
            }
        }

        private void TxtValor4_TextChanged(object sender, EventArgs e)
        {
            if (txtValor4.Text == "")
            {
                txtValor4.Text = "0,00";
            }
            else
            {
                Valor1 = decimal.Parse(txtValor4.Text);
                Valor2 = decimal.Parse(txtValor5.Text);
                ValorTotalGeral = Valor1 + Valor2;
                txtValor6.Text = ValorTotalGeral.ToString();
                valorTotal1 = decimal.Parse(txtValor3.Text);
                valorTotal2 = decimal.Parse(txtValor6.Text);
                valorTotal3 = decimal.Parse(txtValor9.Text);
                ValorTotalGeral = valorTotal1 + valorTotal2 + valorTotal3;
                txtValor10.Text = ValorTotalGeral.ToString();
            }
        }

        private void TxtValor5_TextChanged(object sender, EventArgs e)
        {
            if (txtValor5.Text == "")
            {
                txtValor5.Text = "0,00";
            }
            else
            {
                Valor1 = decimal.Parse(txtValor4.Text);
                Valor2 = decimal.Parse(txtValor5.Text);
                ValorTotalGeral = Valor1 + Valor2;
                txtValor6.Text = ValorTotalGeral.ToString();
                valorTotal1 = decimal.Parse(txtValor3.Text);
                valorTotal2 = decimal.Parse(txtValor6.Text);
                valorTotal3 = decimal.Parse(txtValor9.Text);
                ValorTotalGeral = valorTotal1 + valorTotal2 + valorTotal3;
                txtValor10.Text = ValorTotalGeral.ToString();
            }
        }

        private void TxtValor7_TextChanged(object sender, EventArgs e)
        {
            if (txtValor7.Text == "")
            {
                txtValor7.Text = "0,00";
            }
            else
            {
                Valor1 = decimal.Parse(txtValor7.Text);
                Valor2 = decimal.Parse(txtValor8.Text);
                ValorTotalGeral = Valor1 + Valor2;
                txtValor9.Text = ValorTotalGeral.ToString();
                valorTotal1 = decimal.Parse(txtValor3.Text);
                valorTotal2 = decimal.Parse(txtValor6.Text);
                valorTotal3 = decimal.Parse(txtValor9.Text);
                ValorTotalGeral = valorTotal1 + valorTotal2 + valorTotal3;
                txtValor10.Text = ValorTotalGeral.ToString();
            }
        }

        private void TxtValor8_TextChanged(object sender, EventArgs e)
        {
            if (txtValor8.Text == "")
            {
                txtValor8.Text = "0,00";
            }
            else
            {
                Valor1 = decimal.Parse(txtValor7.Text);
                Valor2 = decimal.Parse(txtValor8.Text);
                ValorTotalGeral = Valor1 + Valor2;
                txtValor9.Text = ValorTotalGeral.ToString();
                valorTotal1 = decimal.Parse(txtValor3.Text);
                valorTotal2 = decimal.Parse(txtValor6.Text);
                valorTotal3 = decimal.Parse(txtValor9.Text);
                ValorTotalGeral = valorTotal1 + valorTotal2 + valorTotal3;
                txtValor10.Text = ValorTotalGeral.ToString();
            }
        }

        private void TxtValor1_Leave(object sender, EventArgs e)
        {
            txtValor1.Text = decimal.Parse(txtValor1.Text.Trim()).ToString("0.00");
        }

        private void TxtValor2_Leave(object sender, EventArgs e)
        {
            txtValor2.Text = decimal.Parse(txtValor2.Text.Trim()).ToString("0.00");
        }

        private void TxtValor4_Leave(object sender, EventArgs e)
        {
            txtValor4.Text = decimal.Parse(txtValor4.Text.Trim()).ToString("0.00");
        }

        private void TxtValor5_Leave(object sender, EventArgs e)
        {
            txtValor5.Text = decimal.Parse(txtValor5.Text.Trim()).ToString("0.00");
        }

        private void TxtValor7_Leave(object sender, EventArgs e)
        {                           
            txtValor7.Text = decimal.Parse(txtValor7.Text.Trim()).ToString("0.00");
        }

        private void TxtValor8_Leave(object sender, EventArgs e)
        {
            txtValor8.Text = decimal.Parse(txtValor8.Text.Trim()).ToString("0.00");
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    if (((int)e.KeyChar) != ((int)Keys.Back))
                        if (e.KeyChar != ',')
                            e.Handled = true;
                        else if (txtValor1.Text.IndexOf(',') > 0)
                            e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    if (((int)e.KeyChar) != ((int)Keys.Back))
                        if (e.KeyChar != ',')
                            e.Handled = true;
                        else if (txtValor2.Text.IndexOf(',') > 0)
                            e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValor4_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    if (((int)e.KeyChar) != ((int)Keys.Back))
                        if (e.KeyChar != ',')
                            e.Handled = true;
                        else if (txtValor4.Text.IndexOf(',') > 0)
                            e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValor5_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    if (((int)e.KeyChar) != ((int)Keys.Back))
                        if (e.KeyChar != ',')
                            e.Handled = true;
                        else if (txtValor5.Text.IndexOf(',') > 0)
                            e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValor7_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    if (((int)e.KeyChar) != ((int)Keys.Back))
                        if (e.KeyChar != ',')
                            e.Handled = true;
                        else if (txtValor7.Text.IndexOf(',') > 0)
                            e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValor8_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    if (((int)e.KeyChar) != ((int)Keys.Back))
                        if (e.KeyChar != ',')
                            e.Handled = true;
                        else if (txtValor8.Text.IndexOf(',') > 0)
                            e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cbPeriodo.SelectedIndex == -1)
            {
                MessageBox.Show("Indique a data de apuraçao!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(txtAno.Text))
            {
                MessageBox.Show("Informe o ano da apuração!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ClassReceita receita = new ClassReceita();

                try
                {
                    receita._RevendaMer_SNF = decimal.Parse(txtValor1.Text);
                    receita._RevendaMer_NF = decimal.Parse(txtValor2.Text);
                    receita._RevendaMer_Total = decimal.Parse(txtValor3.Text);
                    receita._VendaInd_SNF = decimal.Parse(txtValor4.Text);
                    receita._VendaInd_NF = decimal.Parse(txtValor5.Text);
                    receita._VendaInd_Tortal = decimal.Parse(txtValor6.Text);
                    receita._Servico_SNF = decimal.Parse(txtValor7.Text);
                    receita._Servico_NF = decimal.Parse(txtValor8.Text);
                    receita._Servico_Total = decimal.Parse(txtValor9.Text);
                    receita._TotalReceitas = decimal.Parse(txtValor10.Text);
                    receita._periodo = cbPeriodo.Text;
                    receita._Ano = txtAno.Text;

                    if (receita.GerarSalvarReceita() == true)
                    {
                        receita.BuscarReceita();
                        this.Cursor = Cursors.WaitCursor;
                        FrmRelatorioReceita relatorio = new FrmRelatorioReceita(receita._id, cbPeriodo.Text, txtAno.Text);
                        relatorio.Show();
                        this.Cursor = Cursors.Default;
                    }
                    else
                    {
                       DialogResult dr = MessageBox.Show("Existe um relatório com o mesmo período e ano. Deseja alterar este dados?", "Mensagem do sistema System RM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dr == DialogResult.Yes)
                        {
                            receita._RevendaMer_SNF = decimal.Parse(txtValor1.Text);
                            receita._RevendaMer_NF = decimal.Parse(txtValor2.Text);
                            receita._RevendaMer_Total = decimal.Parse(txtValor3.Text);
                            receita._VendaInd_SNF = decimal.Parse(txtValor4.Text);
                            receita._VendaInd_NF = decimal.Parse(txtValor5.Text);
                            receita._VendaInd_Tortal = decimal.Parse(txtValor6.Text);
                            receita._Servico_SNF = decimal.Parse(txtValor7.Text);
                            receita._Servico_NF = decimal.Parse(txtValor8.Text);
                            receita._Servico_Total = decimal.Parse(txtValor9.Text);
                            receita._TotalReceitas = decimal.Parse(txtValor10.Text);
                            receita._periodo = cbPeriodo.Text;
                            receita._Ano = txtAno.Text;
                            receita.AlterarRelatorio();
                            receita.BuscarReceita();
                            FrmRelatorioReceita relatorio = new FrmRelatorioReceita(receita._id, cbPeriodo.Text, txtAno.Text);
                            relatorio.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
