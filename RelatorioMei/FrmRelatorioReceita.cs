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
    public partial class FrmRelatorioReceita : Form
    {
        int id;
        public FrmRelatorioReceita(int id, string periodo, string ano)
        {
            InitializeComponent();
            this.id = id;
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("CNPJ", Settings.Default["CNPJ"].ToString()));
            rpc.Add(new ReportParameter("EmpreendedorIndividual", Settings.Default["EmpreendedorIndividual"].ToString()));
            rpc.Add(new ReportParameter("periodo", periodo));
            rpc.Add(new ReportParameter("ano", ano));
            rpc.Add(new ReportParameter("estado", Settings.Default["Estado"].ToString()));
            rpc.Add(new ReportParameter("local", Settings.Default["Cidade"].ToString()));
            rpc.Add(new ReportParameter("data",DateTime.Now.ToShortDateString()));
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();

            this.RelatorioReceitasTableAdapter.Fill(this.dsRelatorio.RelatorioReceitas, id);
            this.reportViewer1.RefreshReport();
        }

        private void FrmRelatorioReceita_Load(object sender, EventArgs e)
        {
            
        }
    }
}
