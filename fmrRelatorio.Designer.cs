namespace Relatorios
{
    partial class fmrRelatorio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetEmpresa = new Relatorios.DataSetEmpresa();
            this.tblSetorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSetorTableAdapter = new Relatorios.DataSetEmpresaTableAdapters.tblSetorTableAdapter();
            this.tblFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFuncionarioTableAdapter = new Relatorios.DataSetEmpresaTableAdapters.tblFuncionarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSetorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetSetor";
            reportDataSource1.Value = this.tblSetorBindingSource;
            reportDataSource2.Name = "DataSetFuncionario";
            reportDataSource2.Value = this.tblFuncionarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Relatorios.RelSetores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(940, 538);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetEmpresa
            // 
            this.DataSetEmpresa.DataSetName = "DataSetEmpresa";
            this.DataSetEmpresa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSetorBindingSource
            // 
            this.tblSetorBindingSource.DataMember = "tblSetor";
            this.tblSetorBindingSource.DataSource = this.DataSetEmpresa;
            // 
            // tblSetorTableAdapter
            // 
            this.tblSetorTableAdapter.ClearBeforeFill = true;
            // 
            // tblFuncionarioBindingSource
            // 
            this.tblFuncionarioBindingSource.DataMember = "tblFuncionario";
            this.tblFuncionarioBindingSource.DataSource = this.DataSetEmpresa;
            // 
            // tblFuncionarioTableAdapter
            // 
            this.tblFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // fmrRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 562);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fmrRelatorio";
            this.Text = "fmrRelatorio";
            this.Load += new System.EventHandler(this.fmrRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSetorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblSetorBindingSource;
        private DataSetEmpresa DataSetEmpresa;
        private System.Windows.Forms.BindingSource tblFuncionarioBindingSource;
        private DataSetEmpresaTableAdapters.tblSetorTableAdapter tblSetorTableAdapter;
        private DataSetEmpresaTableAdapters.tblFuncionarioTableAdapter tblFuncionarioTableAdapter;
    }
}