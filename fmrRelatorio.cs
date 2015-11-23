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
    public partial class fmrRelatorio : Form
    {
        public fmrRelatorio()
        {
            InitializeComponent();
        }

        private void fmrRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetEmpresa.tblSetor' table. You can move, or remove it, as needed.
            this.tblSetorTableAdapter.Fill(this.DataSetEmpresa.tblSetor);
            // TODO: This line of code loads data into the 'DataSetEmpresa.tblFuncionario' table. You can move, or remove it, as needed.
            this.tblFuncionarioTableAdapter.Fill(this.DataSetEmpresa.tblFuncionario);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer3.RefreshReport();
        }
    }
}
