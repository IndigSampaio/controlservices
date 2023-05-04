using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.lgn_users'. Você pode movê-la ou removê-la conforme necessário.
            this.lgn_usersTableAdapter.Fill(this.gldturfreDeployDataSet.lgn_users);

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

            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=mssql-115648-0.cloudclusters.net,10046; Initial Catalog=gldturfreDeploy;User ID=PedroSampaio;Password=DanielePedro1!";
            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();
                int result = this.lgn_usersTableAdapter.FillByLgn(gldturfreDeployDataSet.lgn_users, txtbx_lgn.Text, txtbx_snh.Text);

                if (result == 1)
                {
                    frm_menu menu = new frm_menu();
                    this.Visible = false;
                    menu.ShowDialog();
                }

                else if (cont <= 3)
                {
                    cont = cont - 1;
                    MessageBox.Show("Usuario ou senha incorreto!\n Tentativas restante: " + cont, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
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

    }
}
