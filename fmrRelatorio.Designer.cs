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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblSetorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetEmpresa = new Relatorios.DataSetEmpresa();
            this.tblFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblSetorTableAdapter = new Relatorios.DataSetEmpresaTableAdapters.tblSetorTableAdapter();
            this.tblFuncionarioTableAdapter = new Relatorios.DataSetEmpresaTableAdapters.tblFuncionarioTableAdapter();
            this.tblSetorTableAdapter1 = new Relatorios.DataSetEmpresaTableAdapters.tblSetorTableAdapter();
            this.dataSetEmpresa1 = new Relatorios.DataSetEmpresa();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.tblSetorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEmpresa1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblSetorBindingSource
            // 
            this.tblSetorBindingSource.DataMember = "tblSetor";
            this.tblSetorBindingSource.DataSource = this.DataSetEmpresa;
            // 
            // DataSetEmpresa
            // 
            this.DataSetEmpresa.DataSetName = "DataSetEmpresa";
            this.DataSetEmpresa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFuncionarioBindingSource
            // 
            this.tblFuncionarioBindingSource.DataMember = "tblFuncionario";
            this.tblFuncionarioBindingSource.DataSource = this.DataSetEmpresa;
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
            this.reportViewer1.Location = new System.Drawing.Point(31, 18);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(861, 480);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblSetorTableAdapter
            // 
            this.tblSetorTableAdapter.ClearBeforeFill = true;
            // 
            // tblFuncionarioTableAdapter
            // 
            this.tblFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // tblSetorTableAdapter1
            // 
            this.tblSetorTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSetEmpresa1
            // 
            this.dataSetEmpresa1.DataSetName = "DataSetEmpresa";
            this.dataSetEmpresa1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 546);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Relatorio Setores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Relatorio Funcionarios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            reportDataSource3.Name = "DataSetFuncionarios";
            reportDataSource3.Value = this.tblFuncionarioBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Relatorios.RelFuncionarios.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(21, 6);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(878, 498);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(939, 520);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Relatorio Funcionarios/Setor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            reportDataSource4.Name = "DataSetFuncionarios";
            reportDataSource4.Value = this.tblFuncionarioBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Relatorios.RelFuncionariosPorSetor.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(6, 6);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(917, 508);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(939, 520);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Grafico Funcionarios/Setor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSetFuncionario";
            reportDataSource5.Value = this.tblFuncionarioBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Relatorios.GraficoFuncPorSetor.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(3, 3);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(933, 514);
            this.reportViewer4.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(939, 520);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Grafico Salarios / Setor";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reportViewer5
            // 
            reportDataSource6.Name = "DataSetFuncionarios";
            reportDataSource6.Value = this.tblFuncionarioBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "Relatorios.GraficoSalarioPorSetor.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(6, 6);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.Size = new System.Drawing.Size(927, 508);
            this.reportViewer5.TabIndex = 0;
            // 
            // fmrRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 562);
            this.Controls.Add(this.tabControl1);
            this.Name = "fmrRelatorio";
            this.Text = "fmrRelatorio";
            this.Load += new System.EventHandler(this.fmrRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSetorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEmpresa1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tblSetorBindingSource;
        private DataSetEmpresa DataSetEmpresa;
        private System.Windows.Forms.BindingSource tblFuncionarioBindingSource;
        private DataSetEmpresaTableAdapters.tblSetorTableAdapter tblSetorTableAdapter;
        private DataSetEmpresaTableAdapters.tblFuncionarioTableAdapter tblFuncionarioTableAdapter;
        private DataSetEmpresaTableAdapters.tblSetorTableAdapter tblSetorTableAdapter1;
        private DataSetEmpresa dataSetEmpresa1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.TabControl tabControl1;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.TabPage tabPage5;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
    }
}