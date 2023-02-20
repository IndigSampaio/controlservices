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
    public partial class frm_lgn : Form
    {

        int cont = 3;

        public frm_lgn()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ver_senha.Checked == false)
            {
                txtbx_snh.PasswordChar = '*';
            }

            else
            {
                txtbx_snh.PasswordChar = '\0';
            }


        }

        private void frm_lgn_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.cad_login'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_loginTableAdapter.Fill(this.glturfreDeployDataSet.cad_login);

            //TODO: esta linha de codigo carrega dados da tablea 'gldturfreDeployDataSet.cad_fun'. Voce pode move-la ou remove-la conforme necessario.
            //this.cad_funTableAdapter.Fill(this.glturfreDeployDataSet.cad_fun);
            this.cad_loginTableAdapter.Fill(this.glturfreDeployDataSet.cad_login);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int result = cad_funTableAdapter.loginFillBy(glturfreDeployDataSet.cad_fun, txtbx_lgn.Text, txtbx_snh.Text);
            int result = cad_loginTableAdapter.loginFillBy(glturfreDeployDataSet.cad_login, txtbx_lgn.Text, txtbx_snh.Text);

            if (result == 1)
            {
                frm_menu menu = new frm_menu();
                this.Visible = false;
                menu.ShowDialog();
            }

            else if (cont <= 3 )
            {
                cont = cont - 1;
                MessageBox.Show("Usuario ou senha incorreto!\n Tentativas restante: " + cont , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }

            if (cont == 0)
            {
                MessageBox.Show("Limite de tentativas atigindo.\nContato o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ver_senha.Checked = false;
                button1.Enabled = false;
                ver_senha.Enabled = false;
                txtbx_lgn.Enabled = false;
                txtbx_snh.Enabled = false;
            }


        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"Chrome.exe", "https://web.whatsapp.com/send?phone=5511984062207");
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void usuariosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cad_funBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void cad_funBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void cad_funBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {

        }

        private void cad_loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cad_loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glturfreDeployDataSet);

        }
    }
}
