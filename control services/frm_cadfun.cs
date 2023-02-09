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

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void group_documentos_Enter(object sender, EventArgs e)
        {

        }

        private void frm_cadfun_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gldturDataSet.cad_fun'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_funTableAdapter.Fill(this.gldturDataSet.cad_fun);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (chkbx_UmDep.Checked == true)
            {
                chkbx_DoisDep.Enabled = false;
                chkbx_TresDep.Enabled = false;
                grpbx_DepUM.Enabled = true;
                
            }

            else if (chkbx_DoisDep.Checked == true)
            {
                chkbx_UmDep.Enabled = false;
                chkbx_TresDep.Enabled = false;
                grpbx_DepUM.Enabled = true;
                grpbx_DepDois.Enabled = true;
            }

            else if (chkbx_TresDep.Checked == true)
            {
                chkbx_UmDep.Enabled = false;
                chkbx_DoisDep.Enabled = false;
                grpbx_DepUM.Enabled = true;
                grpbx_DepDois.Enabled = true;
                grpbx_DepTres.Enabled = true;
            }

            else
            {
                chkbx_UmDep.Enabled = true;
                chkbx_DoisDep.Enabled = true;
                chkbx_TresDep.Enabled = true;
                grpbx_DepUM.Enabled = false;
                grpbx_DepDois.Enabled = false;
                grpbx_DepTres.Enabled = false;
            }

        }

        private void cad_funBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cad_funBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gldturDataSet);

        }
    }
}
