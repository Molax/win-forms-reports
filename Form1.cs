using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relatorios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRelSetor_Click(object sender, EventArgs e)
        {

            fmrRelatorio frm = new fmrRelatorio();

            frm.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Empresa", "Empresa do Yuri"));

            frm.reportViewer2.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Empresa", "Empresa do Yuri"));

            frm.Show();
        }
    }
}
