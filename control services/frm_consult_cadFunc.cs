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
    public partial class frm_consult_cadFunc : Form
    {
        public frm_consult_cadFunc()
        {
            InitializeComponent();
        }

        private void frm_consult_cadFunc_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.cad_fun'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_funTableAdapter.Fill(this.glturfreDeployDataSet.cad_fun);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.cad_fun'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_funTableAdapter.Fill(this.glturfreDeployDataSet.cad_fun);

        }

        private void cad_funBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cad_funBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glturfreDeployDataSet);

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void cad_funBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cad_funBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glturfreDeployDataSet);

        }

        private void cad_funListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
