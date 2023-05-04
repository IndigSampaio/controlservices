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

        private void cad_clieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_consultCli_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.cad_cli'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_cliTableAdapter.Fill(this.gldturfreDeployDataSet.cad_cli);
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.cad_clie'. Você pode movê-la ou removê-la conforme necessário.

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
                msktxbx_CpfCnpj.Mask = "999,999,999-99"; 
            }

            else if (cmb_CpfCnpj.Text == "CNPJ")
            {
                 msktxbx_CpfCnpj.Mask = "99,999,999/9999-99";
            }

            else
            {
                msktxbx_CpfCnpj.Mask = "";
            }

        }

        private void txtbx_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (chkbx_PesquisaNome.Checked == true)
            {
                chkbx_PesquisaCPF.Enabled = false;  
                this.cad_cliTableAdapter.FillByConsultNomeCli(this.gldturfreDeployDataSet.cad_cli, txtbx_nome.Text);
            }

            else if (chkbx_PesquisaCPF.Checked == true)
            {
                chkbx_PesquisaNome.Enabled = false;
                //this.cad_cliTableAdapter.FillByCadCliCpfCnpj(this.gldturfreDeployDataSet.cad_clie, txtbx_nome.Text);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
