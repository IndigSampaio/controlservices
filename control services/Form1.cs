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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void batevolta_dd64LBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.batevolta_dd64LBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glturfreDeployDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.batevolta_dd60L'. Você pode movê-la ou removê-la conforme necessário.
            this.batevolta_dd60LTableAdapter.Fill(this.glturfreDeployDataSet.batevolta_dd60L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.batevolta_dd64L'. Você pode movê-la ou removê-la conforme necessário.
            this.batevolta_dd64LTableAdapter.Fill(this.glturfreDeployDataSet.batevolta_dd64L);

        }

        //this.batevolta_dd60LTableAdapter.FillByCidadeDD60(this.glturfreDeployDataSet.batevolta_dd60L, textBox1.Text);
        //this.batevolta_dd64LTableAdapter.FillByCidadeDD64(this.glturfreDeployDataSet.batevolta_dd64L, textBox1.Text);

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.batevolta_dd64LTableAdapter.FillByBateVolta_DD64(this.glturfreDeployDataSet.batevolta_dd64L, textBox1.Text);
            this.batevolta_dd60LTableAdapter.FillByBateVolta_DD60(this.glturfreDeployDataSet.batevolta_dd60L, textBox1.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            grpbxDD60L.Visible = false;
            grpbxDD64L.Visible = false;

            if (chkbxDD64.Checked == true)
            {
                chkbxDD60.Enabled = false;
                //  grpbxDD64L.Visible = true;
                txtbox_valor.Text = valorTextBox1.Text;
                
            }

            else if (chkbxDD60.Checked == true)
            {
                chkbxDD64.Enabled = false;
                // grpbxDD60L.Visible = true;
                txtbox_valor.Text = valorTextBox.Text;    

            }

            else
            {
                chkbxDD60.Enabled = true;
                chkbxDD64.Enabled = true;
                txtbox_valor.Text = "";
            }
        }

        private void valorTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
