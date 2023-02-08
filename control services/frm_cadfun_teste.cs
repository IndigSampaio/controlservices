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
    public partial class frm_cadfun_teste : Form
    {
        int contador = 1;

        public frm_cadfun_teste()
        {
            InitializeComponent();
        }

        private void testeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void frm_cadfun_teste_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gldturDataSet1.teste'. Você pode movê-la ou removê-la conforme necessário.
            this.testeTableAdapter.Fill(this.gldturDataSet1.teste);
            // TODO: esta linha de código carrega dados na tabela 'gldturDataSet.teste'. Você pode movê-la ou removê-la conforme necessário.
            this.testeTableAdapter.Fill(this.gldturDataSet.teste);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ver_senha.Checked == true)
            {
                txtbx_snh.PasswordChar = '\0';
            }

            else
            {
                txtbx_snh.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gldturDataSet);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.Validate();
            tabControl1.Enabled = true;
            this.testeBindingSource.AddNew();

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tabControl1.Enabled = false;
            this.Validate();
            this.testeBindingSource.CancelEdit();
        }
    }
}
