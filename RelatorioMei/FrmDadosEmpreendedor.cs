using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RelatorioMei.Properties;


namespace RelatorioMei
{
    public partial class FrmDadosEmpreendedor : Form
    {
        public FrmDadosEmpreendedor()
        {
            InitializeComponent();
        }

        ErrorProvider errorProvider = new ErrorProvider();

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            if (!mkCNPJ.MaskCompleted)
            {
                errorProvider.Clear();
                MessageBox.Show("Complete todo o campo do 'CNPJ'", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(mkCNPJ, "Campo obrigatório!");
                mkCNPJ.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtEmpreendedorIndividual.Text.Trim()))
            {
                errorProvider.Clear();
                MessageBox.Show("Preenche o campo 'Empreendedor Individual'", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtEmpreendedorIndividual, "Campo obrigatório!");
                txtEmpreendedorIndividual.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtCidade.Text.Trim()))
            {
                errorProvider.Clear();
                MessageBox.Show("Preencha o campo do 'Cidade'", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtCidade, "Campo obrigatório!");
                txtCidade.Focus();
                return;
            }
            else if(cbEstado.SelectedIndex == -1)
            {
                errorProvider.Clear();
                MessageBox.Show("Selecione o  'Estado'", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(cbEstado, "Campo obrigatório!");
                cbEstado.Focus();
                return;
            }
            else
            {
                if (DOC.ValidarCNPJ(mkCNPJ.Text))
                {
                    Settings.Default["CNPJ"] = mkCNPJ.Text.Trim();
                    Settings.Default["EmpreendedorIndividual"] = txtEmpreendedorIndividual.Text.Trim();
                    Settings.Default["Cidade"] = txtCidade.Text.Trim();
                    Settings.Default["Estado"] = cbEstado.Text;
                    Settings.Default.Save();
                    this.Close();
                }
                else
                    MessageBox.Show("CNPJ inválido!", "Mensagem do sistema System RM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }        

        private void FrmDadosEmpreendedor_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Settings.Default["CNPJ"].ToString()) && !string.IsNullOrEmpty(Settings.Default["EmpreendedorIndividual"].ToString()) && !string.IsNullOrEmpty(Settings.Default["Cidade"].ToString()) && !string.IsNullOrEmpty(Settings.Default["Estado"].ToString()))
            {
                mkCNPJ.Text = Settings.Default["CNPJ"].ToString();
                txtEmpreendedorIndividual.Text = Settings.Default["EmpreendedorIndividual"].ToString();
                txtCidade.Text = Settings.Default["Cidade"].ToString();
                cbEstado.Text = Settings.Default["Estado"].ToString();
            }
        }

        private void mkCNPJ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSalvar_Click(sender, e);
            }
        }

        private void txtEmpreendedorIndividual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSalvar_Click(sender, e);
            }
        }

        private void txtCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSalvar_Click(sender, e);
            }
        }

        private void cbEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSalvar_Click(sender, e);
            }
        }

        private void mkCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void txtEmpreendedorIndividual_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }       
    }
}
