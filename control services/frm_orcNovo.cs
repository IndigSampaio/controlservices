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
    public partial class frm_orcNovo : Form
    {
        public frm_orcNovo()
        {
            InitializeComponent();
        }

        private void cad_cliBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void frm_orcNovo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.orcamento'. Você pode movê-la ou removê-la conforme necessário.
            this.orcamentoTableAdapter.Fill(this.glturfreDeployDataSet.orcamento);


        }



        private void button4_Click(object sender, EventArgs e)
        {
            frm_cadCli cadCli = new frm_cadCli();
            cadCli.ShowDialog();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void orcamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void frm_orcNovo_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.orcamento'. Você pode movê-la ou removê-la conforme necessário.
            this.orcamentoTableAdapter.Fill(this.glturfreDeployDataSet.orcamento);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orcamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glturfreDeployDataSet);
        }

        private void orcamentoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {


        }

        private void frm_orcNovo_Load_2(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.orcamento'. Você pode movê-la ou removê-la conforme necessário.
            this.orcamentoTableAdapter.Fill(this.glturfreDeployDataSet.orcamento);

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.orcamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glturfreDeployDataSet);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grpbx_InfCli.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
