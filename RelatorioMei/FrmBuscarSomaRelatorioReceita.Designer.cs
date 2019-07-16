namespace RelatorioMei
{
    partial class FrmBuscarSomaRelatorioReceita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarSomaRelatorioReceita));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsRelatorio = new RelatorioMei.dsRelatorio();
            this.SomarRelatorioReceitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SomarRelatorioReceitasTableAdapter = new RelatorioMei.dsRelatorioTableAdapters.SomarRelatorioReceitasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SomarRelatorioReceitasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SomarRelatorioReceitasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RelatorioMei.RelatorioBuscarSomaRelatorioReceita.rdlc";
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
            // SomarRelatorioReceitasBindingSource
            // 
            this.SomarRelatorioReceitasBindingSource.DataMember = "SomarRelatorioReceitas";
            this.SomarRelatorioReceitasBindingSource.DataSource = this.dsRelatorio;
            // 
            // SomarRelatorioReceitasTableAdapter
            // 
            this.SomarRelatorioReceitasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBuscarSomaRelatorioReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscarSomaRelatorioReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO MENSAL DAS RECEITAS BRUTAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBurcarRelatorioReceita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SomarRelatorioReceitasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SomarRelatorioReceitasBindingSource;
        private dsRelatorio dsRelatorio;
        private dsRelatorioTableAdapters.SomarRelatorioReceitasTableAdapter SomarRelatorioReceitasTableAdapter;
    }
}