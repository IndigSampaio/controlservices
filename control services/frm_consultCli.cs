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
    public partial class frm_consultCli : Form
    {
        public frm_consultCli()
        {
            InitializeComponent();
        }

        private void cad_cliBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cad_cliBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glturfreDeployDataSet);

        }

        private void frm_consultCli_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.cad_cli'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_cliTableAdapter.Fill(this.glturfreDeployDataSet.cad_cli);

            if (txtbx_nome.Text == "" || msktxbx_CpfCnpj.Text == "")
            {
                lbl_CpfCnpj.Text = "";
                lbl_email.Text = "";
                lbl_id.Text = "";
                lbl_nome.Text = "";
                lbl_tel.Text = "";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
            if (chkbx_PesquisaCPF.Checked == true)
            {
                cmb_CpfCnpj.Enabled = true;
                msktxbx_CpfCnpj.Enabled = true;

            }

            else if (chkbx_PesquisaNome.Checked == true)
            {
                txtbx_nome.Enabled = true;
            }

            if (cmb_CpfCnpj.Text == "CPF")
            {
                msktxbx_CpfCnpj.Mask = "999.999.999-99"; 
            }

            else if (cmb_CpfCnpj.Text == "CNPJ")
            {
                msktxbx_CpfCnpj.Mask = "99.999.999/9999-99";
            }

            else
            {
                msktxbx_CpfCnpj.Mask = "";
            }

        }

        private void txtbx_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
