using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_services
{
    public partial class frm_consultOrc : Form
    {
        public frm_consultOrc()
        {
            InitializeComponent();
        }

        private void orcamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orcamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gldturfreDeployDataSet);

        }

        private void frm_consultOrc_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.orcamento'. Você pode movê-la ou removê-la conforme necessário.
            this.orcamentoTableAdapter.Fill(this.gldturfreDeployDataSet.orcamento);

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
