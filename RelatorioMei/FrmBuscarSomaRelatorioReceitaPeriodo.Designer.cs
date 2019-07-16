namespace RelatorioMei
{
    partial class FrmBuscarSomaRelatorioReceitaPeriodo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarSomaRelatorioReceitaPeriodo));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsRelatorio = new RelatorioMei.dsRelatorio();
            this.SomaRelatorioReceitasPeriodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SomaRelatorioReceitasPeriodoTableAdapter = new RelatorioMei.dsRelatorioTableAdapters.SomaRelatorioReceitasPeriodoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SomaRelatorioReceitasPeriodoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SomaRelatorioReceitasPeriodoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RelatorioMei.RpSomaRelatorioPeriodo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsRelatorio
            // 
            this.dsRelatorio.DataSetName = "dsRelatorio";
            this.dsRelatorio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SomaRelatorioReceitasPeriodoBindingSource
            // 
            this.SomaRelatorioReceitasPeriodoBindingSource.DataMember = "SomaRelatorioReceitasPeriodo";
            this.SomaRelatorioReceitasPeriodoBindingSource.DataSource = this.dsRelatorio;
            // 
            // SomaRelatorioReceitasPeriodoTableAdapter
            // 
            this.SomaRelatorioReceitasPeriodoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBuscarSomaRelatorioReceitaPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscarSomaRelatorioReceitaPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO MENSAL DAS RECEITAS BRUTAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SomaRelatorioReceitasPeriodoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SomaRelatorioReceitasPeriodoBindingSource;
        private dsRelatorio dsRelatorio;
        private dsRelatorioTableAdapters.SomaRelatorioReceitasPeriodoTableAdapter SomaRelatorioReceitasPeriodoTableAdapter;
    }
}