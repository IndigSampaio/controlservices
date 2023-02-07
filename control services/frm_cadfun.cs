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
    public partial class frm_cadfun : Form
    {
        public frm_cadfun()
        {
            InitializeComponent();
        }

        private void cad_funBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cad_funBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gldturDataSet);

        }

        private void frm_cadfun_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gldturDataSet.cad_fun'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_funTableAdapter.Fill(this.gldturDataSet.cad_fun);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
