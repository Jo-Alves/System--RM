using RelatorioMei.Properties;
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
    
    public partial class FrmCarregamentoSistema : Form
    {
        public FrmCarregamentoSistema()
        {
            InitializeComponent();
        }

        private void timerCarregar_Tick(object sender, EventArgs e)
        {
            if (pB_Carregar.Value < 100)
            {
                pB_Carregar.Value += 2;
            }
            else
            {
                timerCarregar.Enabled = false;
                this.Visible = false;
                ;
                if (verificarEmpreendedor() == true)
                {
                    FrmAutenticacao autenticacao = new FrmAutenticacao();
                    autenticacao.ShowDialog();
                }
                else
                {
                    FrmDadosEmpreendedor dadosEmpreendedor = new FrmDadosEmpreendedor();
                    dadosEmpreendedor.ShowDialog();
                    if (verificarEmpreendedor() == true)
                    {
                        FrmAutenticacao autenticacao = new FrmAutenticacao();
                        autenticacao.ShowDialog();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private bool verificarEmpreendedor()
        {
            if (!string.IsNullOrEmpty(Settings.Default["CNPJ"].ToString()) && !string.IsNullOrEmpty(Settings.Default["EmpreendedorIndividual"].ToString()) && !string.IsNullOrEmpty(Settings.Default["Cidade"].ToString()))
            {
                return true;
            }
            else
                return false;           
        }
    }
}
