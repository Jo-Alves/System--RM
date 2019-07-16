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
    public partial class FrmBuscarSomaRelatorioReceitaPeriodo : Form
    {
        public FrmBuscarSomaRelatorioReceitaPeriodo(string Periodo, string Ano)
        {
            InitializeComponent();
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("CNPJ", Settings.Default["CNPJ"].ToString()));
            rpc.Add(new ReportParameter("EmpreendedorIndividual", Settings.Default["EmpreendedorIndividual"].ToString()));
            rpc.Add(new ReportParameter("estado", Settings.Default["Estado"].ToString()));
            rpc.Add(new ReportParameter("local", Settings.Default["Cidade"].ToString()));
            rpc.Add(new ReportParameter("data", "__/__/____"));
            rpc.Add(new ReportParameter("periodo", Periodo));
            rpc.Add(new ReportParameter("ano", Ano));
            reportViewer1.LocalReport.SetParameters(rpc);
            this.SomaRelatorioReceitasPeriodoTableAdapter.Fill(this.dsRelatorio.SomaRelatorioReceitasPeriodo, Periodo, Ano);

            this.reportViewer1.RefreshReport();
        }
    }
}
