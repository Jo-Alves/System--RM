using Microsoft.Reporting.WinForms;
using RelatorioMei.Properties;
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
    public partial class FrmBuscarSomaRelatorioReceita : Form
    {
        public FrmBuscarSomaRelatorioReceita(string Ano)
        {
            InitializeComponent();
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("CNPJ", Settings.Default["CNPJ"].ToString()));
            rpc.Add(new ReportParameter("EmpreendedorIndividual", Settings.Default["EmpreendedorIndividual"].ToString()));
            rpc.Add(new ReportParameter("estado", Settings.Default["Estado"].ToString()));
            rpc.Add(new ReportParameter("local", Settings.Default["Cidade"].ToString()));
            rpc.Add(new ReportParameter("data", "__/__/____"));
            reportViewer1.LocalReport.SetParameters(rpc);
            this.SomarRelatorioReceitasTableAdapter.Fill(this.dsRelatorio.SomarRelatorioReceitas, Ano);

            this.reportViewer1.RefreshReport();
        }

        private void FrmBurcarRelatorioReceita_Load(object sender, EventArgs e)
        {
            
        }
    }
}
