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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        ClassUsuario Usuario = new ClassUsuario();
        ErrorProvider errorProvider = new ErrorProvider();
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()))
            {
                errorProvider.Clear();
                MessageBox.Show("Preencha o campo Usuário!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtUsuario, "Campo obrigatório");
                txtUsuario.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtSenha.Text.Trim()))
            {
                errorProvider.Clear();
                MessageBox.Show("Preencha o campo Senha!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtSenha, "Campo obrigatório");
                txtSenha.Focus();
                return;
            }
            else
            {
                try
                {
                    Usuario._usuario = txtUsuario.Text;
                    Usuario._senha = ClassSecurityPassword.Pass(txtSenha.Text);
                    if (Usuario.Salvar() == false)
                    {
                        MessageBox.Show("Usuário cadastrado com sucesso!", "Mensagem do sistema System RM", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtSenha.Clear();
                        txtUsuario.Clear();
                        txtUsuario.Focus();
                    }
                    else
                        MessageBox.Show("Usuário já existe! Crie outro usuário!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()))
            {
                errorProvider.Clear();
                MessageBox.Show("Preencha o campo Usuário!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtUsuario, "Campo obrigatório");
                txtUsuario.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtSenha.Text.Trim()))
            {
                errorProvider.Clear();
                MessageBox.Show("Preencha o campo Senha!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtSenha, "Campo obrigatório");
                txtSenha.Focus();
                return;
            }
            else
            {
                try
                {
                    Usuario._usuario = txtUsuario.Text;
                    Usuario._senha = ClassSecurityPassword.Pass(txtSenha.Text);

                    if (Usuario.Autenticar() == true)
                    {
                        DialogResult dr = MessageBox.Show("Deseja mesmo excluir o usuário?", "Aviso do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                        if (dr == DialogResult.Yes)
                        {
                            Usuario.Excluir();

                            MessageBox.Show("Dados do usuário excluido com sucesso!", "Mensagem do sistema System RM", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtSenha.Clear();
                            txtUsuario.Clear();
                            txtUsuario.Focus();
                        }
                    }
                    else
                        MessageBox.Show("Usuário não existe! Verifique novamente a sua senha ou o usuário!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()))
            {
                errorProvider.Clear();
                MessageBox.Show("Preencha o campo Usuário!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtUsuario, "Campo obrigatório");
                txtUsuario.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtSenha.Text.Trim()))
            {
                errorProvider.Clear();
                MessageBox.Show("Preencha o campo Senha!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtSenha, "Campo obrigatório");
                txtSenha.Focus();
                return;
            }
            else
            {
                try
                {
                    Usuario._usuario = txtUsuario.Text;
                    Usuario._senha = ClassSecurityPassword.Pass(txtSenha.Text);



                    DialogResult dr = MessageBox.Show("Deseja mesmo alterar a senha?", "Aviso do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (dr == DialogResult.Yes)
                    {
                        if (Usuario.Editar() == true)
                        {
                            MessageBox.Show("Senha alterado com sucesso!", "Mensagem do sistema System RM", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtSenha.Clear();
                            txtUsuario.Clear();
                            txtUsuario.Focus();
                        }
                        else
                            MessageBox.Show("Usuário não existe! Verifique novamente o usuário!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }
    }
}
