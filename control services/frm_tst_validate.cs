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
    public partial class frm_tst_validate : Form
    {
        public frm_tst_validate()
        {
            InitializeComponent();
        }

        private void tst_lgnBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void frm_tst_validate_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gldturDataSet.tst_lgn'. Você pode movê-la ou removê-la conforme necessário.
            this.tst_lgnTableAdapter.Fill(this.gldturDataSet.tst_lgn);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tst_lgnBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.gldturDataSet);
            groupBox1.Enabled = true;
            btn_add.Enabled = false;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tst_lgnBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.gldturDataSet);
        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }
    }
}
